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

//public class BookSqliteRepository : IBookRepository
//{
//    private readonly ILogger<BookSqliteRepository> logger;
//    private readonly BookstoreDbContext bookstoreDbContext;

//    public BookSqliteRepository(ILogger<BookSqliteRepository> logger, BookstoreDbContext bookstoreDbContext)
//    {
//        this.logger = logger;
//        this.bookstoreDbContext = bookstoreDbContext;
//    }

//    public async Task AddAsync(Book item)
//    {
//        var bookstoreBook = new BookstoreBook();
//        bookstoreBook.Title = item.Title;
//        bookstoreBook.InternationalStandardBookNumber = item.InternationalStandardBookNumber;
//        bookstoreBook.Format = item.Format;

//        await bookstoreDbContext.Books.AddAsync(bookstoreBook);
//    }

//    public async Task<IEnumerable<Book>> ListAsync()
//    {
//        throw new NotImplementedException();

//        ////Builders<Book>.Projection.Exclude(b => b.)
//        //var bookCursor = await bookCollection.FindAsync(Builders<Book>.Filter.Empty);

//        //return await bookCursor.ToListAsync();
//    }
//}

public class BookSqliteRepository : IBookRepository
{
    private readonly ILogger<BookSqliteRepository> logger;
    private readonly BookstoreSqliteDbContext dbContext;

    public BookSqliteRepository(ILogger<BookSqliteRepository> logger, BookstoreSqliteDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public async Task AddAsync(Book item)
    {
        using var connection = dbContext.CreateConnection();

        var command = connection.CreateCommand();
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = @"
INSERT INTO book (title, isbn, format) VALUES ($title, $isbn, $format);";

        command.Parameters.AddWithValue("$title", "value");
        command.Parameters.AddWithValue("isbn", "value");
        command.Parameters.AddWithValue("$format", "value");

        connection.Open();

        int affectedRows = await command.ExecuteNonQueryAsync();
    }

    public async Task<IEnumerable<Book>> ListAsync()
    {
        List<Book> books = new List<Book>();

        using var connection = dbContext.CreateConnection();

        var command = connection.CreateCommand();
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = @"
SELECT * FROM book;";

        //command.Parameters.AddWithValue("$title", "value");
        //command.Parameters.AddWithValue("isbn", "value");
        //command.Parameters.AddWithValue("$format", "value");

        connection.Open();

        Microsoft.Data.Sqlite.SqliteDataReader reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            //reader["asd"]
            books.Add(new Book
            {
                Title = reader["title"].ToString()
            });
        }

        return books;
    }
}