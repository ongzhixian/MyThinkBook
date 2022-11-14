using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace MyThinkBook.Web.HostedServices;

public class RabbitMqListener : IHostedService
{
    private const string CLOUD_AMQP_URL_CONFIGURATION_KEY = "cloud_amqp:armadillo:url";

    private readonly ILogger<RabbitMqListener> logger;

    private readonly IConnection connection;

    private readonly IModel channel;

    public RabbitMqListener(ILogger<RabbitMqListener> logger, IConfiguration configuration)
    {
        this.logger = logger;

        var cloud_amqp_url = configuration[CLOUD_AMQP_URL_CONFIGURATION_KEY];

        ArgumentException.ThrowIfNullOrEmpty(cloud_amqp_url);

        var factory = new ConnectionFactory() { Uri = new Uri(cloud_amqp_url) };

        connection = factory.CreateConnection();

        channel = connection.CreateModel();
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        Register();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        this.connection.Close();
        return Task.CompletedTask;
    }

    // Registered consumer monitoring here
    public void Register()
    {
        //    Console.WriteLine($"RabbitListener register,routeKey:{RouteKey}");
        //    channel.ExchangeDeclare(exchange: "message", type: "topic");
        //    channel.QueueDeclare(queue: QueueName, exclusive: false);
        //    channel.QueueBind(queue: QueueName,
        //                      exchange: "message",
        //                      routingKey: RouteKey);

        //    var consumer = new EventingBasicConsumer(channel);

        //    consumer.Received += (model, ea) =>
        //    {
        //        var body = ea.Body;
        //        var message = Encoding.UTF8.GetString(body);
        //        var result = Process(message);
        //        if (result)
        //        {
        //            channel.BasicAck(ea.DeliveryTag, false);
        //        }
        //    };

        //    channel.BasicConsume(queue: QueueName, consumer: consumer);

        channel.QueueDeclare(
            queue: "hello",
            durable: true,
            exclusive: false,
            autoDelete: false,
            arguments: null);

        var consumer = new EventingBasicConsumer(channel);

        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var result = Process(message);
            if (result)
            {
                channel.BasicAck(ea.DeliveryTag, false);
            }
            logger.LogWarning(" [x] Received {0}", message);
        };

        channel.BasicConsume(
            queue: "hello",
            autoAck: false,
            consumer: consumer);

    }

    private bool Process(string message)
    {
        return false;
    }
}
