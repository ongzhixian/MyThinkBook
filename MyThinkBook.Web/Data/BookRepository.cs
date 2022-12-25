using MongoDB.Driver;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IBookRepository
{
    Task<int> SaveChangesAsync();

    void Add(Book item);

    Task<List<Book>> ListAsync();

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

    public void Add(Book item)
    {
        throw new NotImplementedException();
        
    }

    public async Task<List<Book>> ListAsync()
    {
        //Builders<Book>.Projection.Exclude(b => b.)
        var bookCursor = await bookCollection.FindAsync(Builders<Book>.Filter.Empty);

        return await bookCursor.ToListAsync();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
