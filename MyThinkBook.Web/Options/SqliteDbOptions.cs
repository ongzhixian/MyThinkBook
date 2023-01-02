using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Options;

public class SqliteDbOptions
{
    //public const string BookstoreDbContextSqliteConnectionStringKey = "ConnectionStrings:BookstoreSqliteDbContext";

    public SqliteDbOptions()
    {
    }

    [Required]
    public string ConnectionString { get; set; } = string.Empty;
}
