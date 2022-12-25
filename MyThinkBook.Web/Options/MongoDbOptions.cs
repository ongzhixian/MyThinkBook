using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Options;

public class MongoDbOptions
{
    public const string SettingsConfigurationKey = "MongoDb";
    public const string LocalConfigurationKey = "mongoDb:minitools";

    [Required]
    public string ConnectionString { get; set; } = string.Empty;
}

