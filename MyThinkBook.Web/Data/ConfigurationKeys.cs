using System.Collections.Immutable;

namespace MyThinkBook.Web.Data;

public interface IConfigurationKeys
{
    string? this[string index]
    {
        get;
    }
}

public class ConfigurationKeys : IConfigurationKeys
{
    public const string CloudMongoDbMiniToolsConnectionString = "mongodb:minitools:ConnectionString";
    private readonly ImmutableDictionary<string, string?> configurationKeys;

    public ConfigurationKeys(IConfiguration configuration)
    {
        configurationKeys = configuration.GetSection("ConfigurationKeys").AsEnumerable().ToImmutableDictionary();

        // Notes:
        //foreach (var kv in configuration.GetSection("ConfigurationKeys").AsEnumerable())
        //{
        //    Console.WriteLine("{0}: {1}", kv.Key, kv.Value);
        //}
    }

    public string? this[string key]
    {
        get 
        { 
            return configurationKeys[key]; 
        }
    }
}
