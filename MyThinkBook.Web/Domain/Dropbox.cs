using System.Text.Json.Serialization;

namespace MyThinkBook.Web.Domain;

//given_nameStringAlso known as a first name.
//surnameStringAlso known as a last name or family name.
//familiar_nameStringLocale-dependent name. In the US, a person's familiar name is their given_name, but elsewhere, it could be any combination of a person's given_name and surname.
//display_nameStringA name that can be used directly to represent the name of a user's Dropbox account.
//abbreviated_nameStringAn abbreviated form of the person's name. Their initials in most locales.

public record FullAccountName
{
    [JsonPropertyName("given_name")]
    public string GivenName { get; set; } = string.Empty;

    [JsonPropertyName("surname")]
    public string Surname { get; set; } = string.Empty;

    [JsonPropertyName("familiar_name")]
    public string FamiliarName { get; set; } = string.Empty;

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonPropertyName("abbreviated_name")]
    public string AbbreviatedName { get; set; } = string.Empty;
}

public record UsersGetCurrentAccountResponse
{
    [JsonPropertyName("name")]
    public FullAccountName Name { get; set; } = new FullAccountName();

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("email_verified")]
    public bool EmailVerified { get; set; }

    [JsonPropertyName("referral_link")]
    public string ReferralLink { get; set; } = string.Empty;
}

public record Oauth2TokenResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = string.Empty;

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; } = string.Empty;

    [JsonPropertyName("expires_in")]
    public int ExpiresInSeconds { get; set; }

    [JsonPropertyName("uid")]
    public string UID { get; set; } = string.Empty;

    [JsonPropertyName("account_id")]
    public string AccountId { get; set; } = string.Empty;
}

public record Oauth2Token
{
    public string BearerAccessToken { get; set; } = string.Empty;
    public DateTime ExpiryDateTimeUtc { get; set; }

    public bool HasExpired
    {
        get
        {
            return DateTime.UtcNow >= ExpiryDateTimeUtc;
        }
    }
    public Oauth2Token()
    {
    }

    public Oauth2Token(Oauth2TokenResponse response)
    {
        this.BearerAccessToken = response.AccessToken;
        this.ExpiryDateTimeUtc = DateTime.UtcNow.AddSeconds(response.ExpiresInSeconds);
    }
}