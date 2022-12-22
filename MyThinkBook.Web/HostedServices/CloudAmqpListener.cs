using MyThinkBook.Web.Services;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace MyThinkBook.Web.HostedServices;

public class CloudAmqpListener : IHostedService
{
    private readonly ILogger<CloudAmqpListener> logger;

    private readonly IMessageQueueService messageQueueService;

    public bool IsActive{ get; private set; }

    public CloudAmqpListener(ILogger<CloudAmqpListener> logger, IMessageQueueService messageQueueService)
    {
        this.logger = logger;

        this.messageQueueService = messageQueueService;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        messageQueueService.Consume("hello", Consumer_Received, "consumer1");

        IsActive = true;

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        messageQueueService.StopConsuming("consumer1");

        IsActive = false;

        return Task.CompletedTask;
    }

    private void Consumer_Received(object? sender, BasicDeliverEventArgs eventArgs)
    {
        var body = eventArgs.Body.ToArray();
        
        var message = Encoding.UTF8.GetString(body);
        
        var result = Process(message);
        
        if (result && sender is IBasicConsumer basicConsumer)
        {
            basicConsumer.Model.BasicAck(eventArgs.DeliveryTag, false);
        }
        
        logger.LogWarning(" [x] Received {0}", message);
    }

    private bool Process(string message)
    {
        Console.WriteLine("Receive message {0}", message);
        return true;
    }

    //public void Register2(ConsumerDelegate receivedEventDelegate)
    //{
    //    //var factory = new ConnectionFactory() { Uri = new Uri("") };

    //    //var connection = factory.CreateConnection();

    //    //var channel = connection.CreateModel();


    //    channel.QueueDeclare(
    //        queue: "hello",
    //        durable: true,
    //        exclusive: false,
    //        autoDelete: false,
    //        arguments: null);

    //    var consumer = new EventingBasicConsumer(channel);

    //    consumer.Received += new EventHandler<BasicDeliverEventArgs>(receivedEventDelegate);

    //    channel.BasicConsume(
    //        queue: "hello",
    //        autoAck: false,
    //        consumer: consumer);

    //}

    //public delegate void ConsumerDelegate(object? sender, BasicDeliverEventArgs e);



    // Registered consumer monitoring here
    //public void Register()
    //{

    //    //    Console.WriteLine($"RabbitListener register,routeKey:{RouteKey}");
    //    //    channel.ExchangeDeclare(exchange: "message", type: "topic");
    //    //    channel.QueueDeclare(queue: QueueName, exclusive: false);
    //    //    channel.QueueBind(queue: QueueName,
    //    //                      exchange: "message",
    //    //                      routingKey: RouteKey);

    //    //    var consumer = new EventingBasicConsumer(channel);

    //    //    consumer.Received += (model, ea) =>
    //    //    {
    //    //        var body = ea.Body;
    //    //        var message = Encoding.UTF8.GetString(body);
    //    //        var result = Process(message);
    //    //        if (result)
    //    //        {
    //    //            channel.BasicAck(ea.DeliveryTag, false);
    //    //        }
    //    //    };

    //    //    channel.BasicConsume(queue: QueueName, consumer: consumer);

    //    channel.QueueDeclare(
    //        queue: "hello",
    //        durable: true,
    //        exclusive: false,
    //        autoDelete: false,
    //        arguments: null);


    //    var consumer = new EventingBasicConsumer(channel);

    //    consumer.Received += (model, ea) =>
    //    {
    //        var body = ea.Body.ToArray();
    //        var message = Encoding.UTF8.GetString(body);
    //        var result = Process(message);
    //        if (result)
    //        {
    //            channel.BasicAck(ea.DeliveryTag, false);
    //        }
    //        logger.LogWarning(" [x] Received {0}", message);
    //    };

    //    channel.BasicConsume(
    //        queue: "hello",
    //        autoAck: false,
    //        consumer: consumer);

    //}

}
