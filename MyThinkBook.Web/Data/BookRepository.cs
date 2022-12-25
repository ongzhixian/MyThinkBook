using MongoDB.Driver;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IBookRepository
{
    Task AddAsync(Book item);

    Task<IEnumerable<Book>> ListAsync();

}

public class BookRepository : IBookRepository
{
    private readonly ILogger<BookRepository> logger;
    private readonly IMongoCollection<Book> bookCollection;

    public BookRepository(ILogger<BookRepository> logger, IBookStoreMongoDbContext mongoDbContext)
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
