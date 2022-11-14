using MongoDB.Driver;

namespace MyThinkBook.Data.MongoDb;

public interface IMongoDbContext
{
    IMongoDatabase MongoDatabase { get; }
}

public class MongoDbContext : IMongoDbContext
{
    private readonly string connectionString;
    private readonly string databaseName;

    public MongoDbContext(string connectionString, string databaseName)
    {
        if (string.IsNullOrWhiteSpace(connectionString)) throw new ArgumentOutOfRangeException(nameof(connectionString));
        if (string.IsNullOrWhiteSpace(databaseName)) throw new ArgumentOutOfRangeException(nameof(databaseName));

        this.connectionString = connectionString;
        this.databaseName = databaseName;
    }

    public IMongoDatabase MongoDatabase
    {
        get
        {
            try
            {
                var mongoClient = new MongoClient(connectionString);

                return mongoClient.GetDatabase(databaseName);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
