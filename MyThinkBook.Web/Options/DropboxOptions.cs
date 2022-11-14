using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Options;

public class DropboxOptions
{
    public const string SettingsConfigurationKey = "Dropbox";
    public const string LocalConfigurationKey = "dropbox:myThinkBook";

    [Required, Url]
    public string AuthorizeUrl { get; set; } = string.Empty;

    [Required, Url]
    public string ApiBaseUrl { get; set; } = string.Empty;

    [Required, Url]
    public string RedirectUrl { get; set; } = string.Empty;

    [Required]
    public string AppKey { get; set; } = string.Empty;

    [Required]
    public string AppSecret { get; set; } = string.Empty;
}

