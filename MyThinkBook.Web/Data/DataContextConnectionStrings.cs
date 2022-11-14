using System.Collections.Immutable;
using System.Configuration;

namespace MyThinkBook.Web.Data;

public interface IDataContextConnectionStrings
{
    string this[string index]
    {
        get;
    }
}

public class DataContextConnectionStrings : IDataContextConnectionStrings
{
    public const string CloudMongoDbMiniToolsConnectionString = "mongodb:minitools:ConnectionString";
    
    private readonly ImmutableDictionary<string, string?> configurationKeys;
    private const string configurationSectionName = "DataContextConnectionStringKeys";
    private const string configurationSectionKeyPrefix = $"{configurationSectionName}:";

    private readonly ImmutableDictionary<string, string?> connectionStrings;

    public DataContextConnectionStrings(IConfiguration configuration)
    {
        //foreach (var kv in configuration.AsEnumerable().ToList())
        //{
        //    Console.WriteLine("a {0}: {1}", kv.Key, kv.Value);
        //}

        //foreach (var kv in configuration.GetSection(configurationSectionName).AsEnumerable())
        //{
        //    Console.WriteLine("{0}: {1}", kv.Key, kv.Value);
        //}

        configurationKeys = configuration.GetSection(configurationSectionName).AsEnumerable().ToImmutableDictionary();

        connectionStrings = configuration.GetSection(configurationSectionName).AsEnumerable().Select(kvp =>
        {
            var mappedKey = MapKey(kvp.Key);
            var mappedValue = MapValue(configuration, kvp.Key);

            if (!string.IsNullOrEmpty(mappedKey) && configurationKeys.ContainsKey(kvp.Key))
            {
                return new KeyValuePair<string, string?>(mappedKey, mappedValue);
            }

            return new KeyValuePair<string, string?>();

        }).Where(kvp => !string.IsNullOrEmpty(kvp.Key))
        .ToImmutableDictionary();
    }

    private string? MapValue(IConfiguration configuration, string key)
    {
        var configurationKey = configurationKeys[key];

        if (configurationKeys.TryGetValue(key, out string? value) && value != null && configurationKey != null)
        {
            return configuration[configurationKey];
        }

        return null;
    }

    private string MapKey(string key)
    {
        if (key.StartsWith(configurationSectionName))
        {
            key = key.Replace(configurationSectionName, string.Empty).TrimStart(':');
        }

        return key;
    }

    public string this[string key]
    {
        get 
        {
            if (connectionStrings.ContainsKey(key))
            {
                return connectionStrings[key] ?? string.Empty;
            }

            return string.Empty;
        }
    }
}
