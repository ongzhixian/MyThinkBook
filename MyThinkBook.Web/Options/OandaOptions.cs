using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Options;

public class OandaOptions
{
    public const string SettingsConfigurationKey = "Oanda";
    public const string LocalConfigurationKey = "oanda";

    [Required, Url]
    public string RestApiUrl { get; set; } = string.Empty;

    [Required, Url]
    public string StreamingApiUrl { get; set; } = string.Empty;

    [Required]
    public string AccountNumber { get; set; } = string.Empty;

    [Required]
    public string ApiKey { get; set; } = string.Empty;
}

