using RabbitMQ.Client;
using System.Text;

namespace MyThinkBook.Web.Modules;

public interface IMessagingModule
{
    void SendMessage(string message);
}

public class RabbitMqMessagingModule : IMessagingModule
{
    private const string CLOUD_AMQP_URL_CONFIGURATION_KEY = "cloud_amqp:armadillo:url";

    private readonly ILogger<RabbitMqMessagingModule> logger;

    private readonly ConnectionFactory factory;

    public RabbitMqMessagingModule(ILogger<RabbitMqMessagingModule> logger, IConfiguration configuration)
    {
        this.logger = logger;

        var cloud_amqp_url = configuration[CLOUD_AMQP_URL_CONFIGURATION_KEY];

        ArgumentException.ThrowIfNullOrEmpty(cloud_amqp_url);

        factory = new ConnectionFactory() { Uri = new Uri(cloud_amqp_url) };
    }

    public void SendMessage(string message)
    {
        try
        {
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(
                    queue: "hello",
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(
                    exchange: "",
                    routingKey: "hello",
                    basicProperties: null,
                    body: body);

                logger.LogInformation(" [x] Sent {0}", message);
            }
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error sending message.");
        }
    }
}