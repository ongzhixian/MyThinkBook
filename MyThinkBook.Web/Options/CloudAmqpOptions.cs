using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Options;

public class CloudAmqpOptions
{
    public const string SettingsConfigurationKey = "CloudAmqp";
    public const string LocalConfigurationKey = "cloud_amqp:armadillo";
    //private const string CLOUD_AMQP_URL_CONFIGURATION_KEY = "cloud_amqp:armadillo:url";

    [Required]
    public string Url { get; set; } = string.Empty;

    
        
}

