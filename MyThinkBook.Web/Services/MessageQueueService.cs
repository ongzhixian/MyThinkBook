using Microsoft.Extensions.Options;
using MyThinkBook.Web.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Collections.Concurrent;
using System.Text;

namespace MyThinkBook.Web.Services;

public interface IMessageQueueService
{
    public delegate void ReceivedDelegate(object? sender, BasicDeliverEventArgs e);

    void Send(string message, string queueName, string routingKey = "", string exchange = "", bool durableQueue = true, bool exclusiveQueue = false);

    string Consume(string queueName, ReceivedDelegate receivedEventDelegate, string userConsumerTag = "");

    void StopConsuming(string comsumerTag);
}


public class CloudAmqpMessagingQueue : IMessageQueueService
{
    private readonly ILogger<CloudAmqpMessagingQueue> logger;

    private readonly ConnectionFactory factory;

    private readonly ConcurrentDictionary<string, IModel> channels = new();

    public CloudAmqpMessagingQueue(ILogger<CloudAmqpMessagingQueue> logger, IOptions<CloudAmqpOptions> cloudAmqpOptions)
    {
        this.logger = logger;

        var cloud_amqp_url = cloudAmqpOptions.Value.Url;

        factory = new ConnectionFactory() { Uri = new Uri(cloud_amqp_url) };
    }

    public string Consume(string queueName, IMessageQueueService.ReceivedDelegate receivedEventDelegate, string userConsumerTag = "")
    {
        IConnection connection = factory.CreateConnection();

        IModel channel = connection.CreateModel();

        DeclareQueue(queueName, channel);

        channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

        var consumer = new EventingBasicConsumer(channel);

        consumer.Received += new EventHandler<BasicDeliverEventArgs>(receivedEventDelegate);
        
        string consumerTag = channel.BasicConsume(queueName, 
            autoAck: false,
            consumerTag: userConsumerTag, 
            noLocal: false, 
            exclusive: false, 
            arguments: null, 
            consumer: consumer);

        //channel.BasicConsume(
        //    queue: queueName,
        //    autoAck: false,
        //    consumer: consumer);

        if (!channels.TryAdd(consumerTag, channel))
        {
            throw new ArgumentException($"Cannot add consumer {consumerTag}");
        }

        logger.LogInformation("Consumer {consumerTag} started", consumerTag);
        return consumerTag;
    }

    public void StopConsuming(string comsumerTag)
    {
        if (channels.TryRemove(comsumerTag, out var channel))
        {
            channel.BasicCancel(comsumerTag);
            channel.Close();
        }
    }

    public void Send(string message, string queueName, string routingKey = "", string exchange = "", bool durableQueue = true, bool exclusiveQueue = false)
    {
        try
        {
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                DeclareQueue(queueName, channel);

                var body = Encoding.UTF8.GetBytes(message);

                var properties = channel.CreateBasicProperties();
                
                properties.Persistent = true;

                channel.BasicPublish(exchange, routingKey, true, properties, body);

                logger.LogInformation(" [x] Sent {0}", message);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error sending message.");
        }
    }

    private QueueDeclareOk DeclareQueue(string queueName, IModel channel, bool durableQueue = true, bool exclusiveQueue = false)
    {
        return channel.QueueDeclare(
            queue: queueName,
            durable: durableQueue,
            exclusive: exclusiveQueue,
            autoDelete: false,
            arguments: null);
        
        //return queueName switch
        //{
        //    "hello" => channel.QueueDeclare(
        //        queue: queueName,
        //        durable: durableQueue,
        //        exclusive: exclusiveQueue,
        //        autoDelete: false,
        //        arguments: null),
        //    _ => throw new ArgumentOutOfRangeException(nameof(queueName))
        //};
        // --OR-- some form of dictionary
    }

    //public Task Consume(string consumerId, string queueName, IMessageQueueService.ReceivedDelegate receivedEventDelegate)
    //{
    //    return Task.Run(() =>
    //    {
    //        IConnection connection = factory.CreateConnection();

    //        IModel channel = connection.CreateModel();

    //        DeclareQueue(queueName, channel);

    //        channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

    //        var consumer = new EventingBasicConsumer(channel);

    //        consumer.Received += new EventHandler<BasicDeliverEventArgs>(receivedEventDelegate);

    //        channel.BasicConsume(
    //            queue: queueName,
    //            autoAck: false,
    //            consumer: consumer);

    //        if (!consumers.TryAdd(consumerId, consumer))
    //        {
    //            throw new ArgumentException($"Cannot add consumer {consumerId}");
    //        }
    //    });
    //}

    //public void GetTestMessage()
    //{

    //    //consumer.Received += (sender, ea) =>
    //    //{
    //    //    var body = ea.Body.ToArray();
    //    //    var message = Encoding.UTF8.GetString(body);
    //    //    Console.WriteLine(" [x] Received {0}", message);

    //    //    int dots = message.Split('.').Length - 1;
    //    //    Thread.Sleep(dots * 1000);

    //    //    Console.WriteLine(" [x] Done");

    //    //    // Note: it is possible to access the channel via
    //    //    //       ((EventingBasicConsumer)sender).Model here
    //    //    channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
    //    //};

    //    try
    //    {
    //        using (var connection = factory.CreateConnection())
    //        using (var channel = connection.CreateModel())
    //        {
    //            DeclareQueue("hello", channel);

    //            channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

    //            var consumer = new EventingBasicConsumer(channel);

    //            consumer.Received += (sender, ea) =>
    //            {
    //                var body = ea.Body.ToArray();
    //                var message = Encoding.UTF8.GetString(body);
    //                Console.WriteLine(" [x] Received {0}", message);

    //                int dots = message.Split('.').Length - 1;
    //                Thread.Sleep(dots * 1000);

    //                Console.WriteLine(" [x] Done");

    //                // Note: it is possible to access the channel via ((EventingBasicConsumer)sender).Model here
    //                channel.BasicAck(ea.DeliveryTag, false);

    //            };

    //            channel.BasicConsume(
    //                queue: "hello",
    //                autoAck: false,
    //                consumer: consumer);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        logger.LogError(ex, "Error sending message.");
    //    }
    //}

    //public void SendMessage(string message)
    //{
    //    try
    //    {
    //        using (var connection = factory.CreateConnection())
    //        using (var channel = connection.CreateModel())
    //        {
    //            DeclareQueue("hello", channel);

    //            var body = Encoding.UTF8.GetBytes(message);

    //            channel.BasicPublish(
    //                exchange: "",
    //                routingKey: "hello",
    //                basicProperties: null,
    //                body: body);

    //            logger.LogInformation(" [x] Sent {0}", message);
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        logger.LogError(ex, "Error sending message.");
    //    }
    //}
}