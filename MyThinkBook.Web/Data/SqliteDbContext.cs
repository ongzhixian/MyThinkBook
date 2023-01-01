using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using MyThinkBook.Web.Options;

namespace MyThinkBook.Web.Data;

public class SqliteDbContext
{
    private readonly ILogger<SqliteDbContext> logger;

    private readonly IOptionsSnapshot<SqliteDbOptions> namedOptions;

    public SqliteDbContext(ILogger<SqliteDbContext> logger, IOptionsSnapshot<SqliteDbOptions> namedOptions)
    {
        this.logger = logger;
        this.namedOptions = namedOptions;
    }

    public void Quer()
    {
        using var connection = new SqliteConnection("Data Source=hello.db");
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText =
        @"
                    CREATE TABLE user (
                        id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL
                    );
                    INSERT INTO user
                    VALUES (1, 'Brice'),
                           (2, 'Alexander'),
                           (3, 'Nate');
                ";
        command.ExecuteNonQuery();
    }
}

public class BookstoreSqliteDbContext
{
    public static readonly string DbContextName = nameof(BookstoreSqliteDbContext);

    private readonly ILogger<BookstoreSqliteDbContext> logger;

    private readonly SqliteDbOptions sqliteDbOptions;

    public BookstoreSqliteDbContext(ILogger<BookstoreSqliteDbContext> logger, IOptionsSnapshot<SqliteDbOptions> namedOptions)
    {
        this.logger = logger;
        sqliteDbOptions = namedOptions.Get(nameof(BookstoreSqliteDbContext));
    }
}
