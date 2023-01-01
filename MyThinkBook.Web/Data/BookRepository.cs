using MongoDB.Driver;
using MyThinkBook.Domain;

namespace MyThinkBook.Web.Data;

public interface IBookRepository
{
    Task AddAsync(Book item);

    Task<IEnumerable<Book>> ListAsync();

}

public class MongoDbBookRepository : IBookRepository
{
    private readonly ILogger<MongoDbBookRepository> logger;
    private readonly IMongoCollection<Book> bookCollection;

    public MongoDbBookRepository(ILogger<MongoDbBookRepository> logger, IBookStoreMongoDbContext mongoDbContext)
    {
        this.logger = logger;

        bookCollection = mongoDbContext.Books;
    }

    public async Task AddAsync(Book item)
    {
        await bookCollection.InsertOneAsync(item);
    }

    public async Task<IEnumerable<Book>> ListAsync()
    {
        //Builders<Book>.Projection.Exclude(b => b.)
        var bookCursor = await bookCollection.FindAsync(Builders<Book>.Filter.Empty);
        
        return await bookCursor.ToListAsync();
    }
}

public class SqliteBookRepository : IBookRepository
{
    private readonly ILogger<SqliteBookRepository> logger;
    private readonly BookstoreDbContext bookstoreDbContext;

    public SqliteBookRepository(ILogger<SqliteBookRepository> logger, BookstoreDbContext bookstoreDbContext)
    {
        this.logger = logger;
        this.bookstoreDbContext = bookstoreDbContext;
    }

    public async Task AddAsync(Book item)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Book>> ListAsync()
    {
        throw new NotImplementedException();

        ////Builders<Book>.Projection.Exclude(b => b.)
        //var bookCursor = await bookCollection.FindAsync(Builders<Book>.Filter.Empty);

        //return await bookCursor.ToListAsync();
    }
}