using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using MyThinkBook.Web.Options;

namespace MyThinkBook.Web.Data;

public class BookstoreSqliteDbContext
{
    public static readonly string DbContextName = nameof(BookstoreSqliteDbContext);

    private readonly ILogger<BookstoreSqliteDbContext> logger;

    private readonly SqliteDbOptions sqliteDbOptions;

    public BookstoreSqliteDbContext(ILogger<BookstoreSqliteDbContext> logger, IOptionsMonitor<SqliteDbOptions> namedOptions)
    {
        this.logger = logger;
        sqliteDbOptions = namedOptions.Get(nameof(BookstoreSqliteDbContext));
    }

    public SqliteConnection CreateConnection()
    {
        return new SqliteConnection(sqliteDbOptions.ConnectionString);
    }
}