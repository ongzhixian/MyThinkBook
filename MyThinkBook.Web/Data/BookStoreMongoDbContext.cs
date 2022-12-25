using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IBookStoreMongoDbContext
{
    IMongoCollection<Book> Books { get; }
}

public class BookStoreMongoDbContext : IBookStoreMongoDbContext
{
    private readonly ILogger<BookStoreMongoDbContext> logger;
    private readonly IMongoDatabase mongoDatabase;

    public BookStoreMongoDbContext(ILogger<BookStoreMongoDbContext> logger, IMongoDbContext mongoDbContext) 
    {
        this.logger = logger;

        configureClassMapper();

        // TODO: erm, the "bookstore" in config?
        mongoDatabase = mongoDbContext.GetDatabase("bookstore");
    }

    private void configureClassMapper()
    {
        //BsonClassMap.RegisterClassMap<Book>(mapper =>
        //{
        //    //classMap.AutoMap();
        //    //classMap.SetIgnoreExtraElements(true);
        //    mapper.MapMember(c => c.Title).SetElementName("title"); ;
        //});
    }

    public IMongoCollection<Book> Books => mongoDatabase.GetCollection<Book>("book");
}
