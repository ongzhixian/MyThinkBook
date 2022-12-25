using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using MyThinkBook.Web.Options;

namespace MyThinkBook.Web.Data;

public interface IMongoDbContext
{
    IMongoDatabase GetDatabase(string databaseName);
}

public class MongoDbContext : IMongoDbContext
{
    private readonly ILogger<MongoDbContext> logger;
    
    private IMongoClient mongoClient { get; set; }

    public MongoDbContext(ILogger<MongoDbContext> logger, IOptions<MongoDbOptions> mongoDbOptions)
    {
        this.logger = logger;

        configureMongoDbConventions();

        mongoClient = new MongoClient(mongoDbOptions.Value.ConnectionString);
    }

    public IMongoDatabase GetDatabase(string databaseName)
    {
        return mongoClient.GetDatabase(databaseName);
    }

    private static void configureMongoDbConventions()
    {
        var conventionPack = new ConventionPack
        {
            new IgnoreExtraElementsConvention(true)
        };

        ConventionRegistry.Register("IgnoreExtraElementsForAllEntities", conventionPack, type => true);
    }
}
