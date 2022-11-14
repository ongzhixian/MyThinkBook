using MongoDB.Bson;
using MongoDB.Driver;
using MyThinkBook.Data.MongoDb;
using MyThinkBook.Web.Models;
using System.Threading;

namespace MyThinkBook.Web.Data;

public interface IMiniToolsDataContext
{
    // Define collections available to context here

    Task<IEnumerable<MongoDbResourceType>> GetResourceTypeListAsync();

    Task AddResourceType(MongoDbResourceType resource);

    Task<MongoDbResourceType> GetResourceType(string objectId);
    
    Task<DeleteResult> DeleteResourceType(string objectId);
    
    Task<UpdateResult> UpdateResourceTypeAsync(string objectId, MongoDbResourceType resource);

    Task SetupIndexAsync();
}

public class MiniToolsDataContext : MongoDbContext, IMiniToolsDataContext
{
    private const string CONNECTION_STRING_NAME = "minitoolsdb";
    private const string DATABASE_NAME = "minitools";

    private readonly ILogger<MiniToolsDataContext> logger;

    public MiniToolsDataContext(ILogger<MiniToolsDataContext> logger, IDataContextConnectionStrings connectionStrings) : base(connectionStrings[CONNECTION_STRING_NAME], DATABASE_NAME)
    {
        this.logger = logger;
    }

    public async Task AddResourceType(MongoDbResourceType resource)
    {
        try
        {
            IMongoCollection<MongoDbResourceType> resourceTypeCollection = MongoDatabase.GetCollection<MongoDbResourceType>("resourceType");

            await resourceTypeCollection.InsertOneAsync(resource);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<MongoDbResourceType> GetResourceType(string objectId)
    {
        try
        {
            var filter = Builders<MongoDbResourceType>.Filter.Eq("_id", new ObjectId(objectId));
            
            IMongoCollection<MongoDbResourceType> resourceTypeCollection = MongoDatabase.GetCollection<MongoDbResourceType>("resourceType");

            return await resourceTypeCollection.Find(filter).FirstOrDefaultAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IEnumerable<MongoDbResourceType>> GetResourceTypeListAsync()
    {
        try
        {
            FilterDefinitionBuilder<MongoDbResourceType> filterBuilder = Builders<MongoDbResourceType>.Filter;

            IMongoCollection<MongoDbResourceType> resourceTypeCollection = MongoDatabase.GetCollection<MongoDbResourceType>("resourceType");

            return await resourceTypeCollection.Find(filterBuilder.Empty).ToListAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<DeleteResult> DeleteResourceType(string objectId)
    {
        try
        {
            var filter = Builders<MongoDbResourceType>.Filter.Eq("_id", new ObjectId(objectId));

            IMongoCollection<MongoDbResourceType> resourceTypeCollection = MongoDatabase.GetCollection<MongoDbResourceType>("resourceType");

            return await resourceTypeCollection.DeleteOneAsync(filter);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<UpdateResult> UpdateResourceTypeAsync(string objectId, MongoDbResourceType resource)
    {
        try
        {
            var filter = Builders<MongoDbResourceType>.Filter.Eq("_id", new ObjectId(objectId));
            var updateDefinition = Builders<MongoDbResourceType>.Update
                .Set(r => r.Name, resource.Name);

            IMongoCollection<MongoDbResourceType> resourceTypeCollection = MongoDatabase.GetCollection<MongoDbResourceType>("resourceType");

            return await resourceTypeCollection.UpdateOneAsync(filter, updateDefinition);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task SetupIndexAsync()
    {
        var mongoDbResourceTypeIndexKeys = Builders<MongoDbResourceType>.IndexKeys;
        var options = new CreateIndexOptions { Unique = true };
        var indexModel = new CreateIndexModel<MongoDbResourceType>(mongoDbResourceTypeIndexKeys.Ascending(x => x.Name), options);

        await MongoDatabase.GetCollection<MongoDbResourceType>("resourceType").Indexes.CreateOneAsync(indexModel);
    }
}
