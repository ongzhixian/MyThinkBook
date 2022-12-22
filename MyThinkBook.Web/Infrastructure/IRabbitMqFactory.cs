using RabbitMQ.Client;

namespace MyThinkBook.Web.Modules;

public interface IRabbitMqFactory
{
    ConnectionFactory Factory { get; }
}

public class RabbitMqFactory : IRabbitMqFactory
{
    private const string CLOUD_AMQP_URL_CONFIGURATION_KEY = "cloud_amqp:armadillo:url";

    private readonly ILogger<CloudAmqpMessagingQueue> logger;

    private readonly ConnectionFactory factory;

    public RabbitMqFactory(ILogger<CloudAmqpMessagingQueue> logger, IConfiguration configuration)
    {
        this.logger = logger;

        var cloud_amqp_url = configuration[CLOUD_AMQP_URL_CONFIGURATION_KEY];

        ArgumentException.ThrowIfNullOrEmpty(cloud_amqp_url);

        factory = new ConnectionFactory() { Uri = new Uri(cloud_amqp_url) };
    }

    public ConnectionFactory Factory => factory;

    public void DeclareQueue(string queueName, IModel channel)
    {
        RabbitMqQueueFactory s = new RabbitMqQueueFactory();
        s["asd"](channel);

        //Dictionary<string, Func<QueueDeclareOk>> x = new Dictionary<string, Func<QueueDeclareOk>>();

        //x.Add("AAA", () => channel.QueueDeclare(
        //    queue: "hello",
        //    durable: true,
        //    exclusive: false,
        //    autoDelete: false,
        //    arguments: null));

        //return x["AAA"]();
        //channel.QueueDeclare(
        //    queue: "hello",
        //    durable: true,
        //    exclusive: false,
        //    autoDelete: false,
        //    arguments: null);
    }
}

public sealed class RabbitMqQueueFactory
{
    private readonly Dictionary<string, Func<IModel, QueueDeclareOk>> queueDeclarations = new Dictionary<string, Func<IModel, QueueDeclareOk>>();

    public RabbitMqQueueFactory() 
    {
        queueDeclarations.Add("hello", channel => channel.QueueDeclare(
            queue: "hello",
            durable: true,
            exclusive: false,
            autoDelete: false,
            arguments: null));
    }

    public Func<IModel, QueueDeclareOk> this[string indexer]
    {
        get
        {
            return queueDeclarations[indexer];
        }
    }
}
