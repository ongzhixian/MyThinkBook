using Microsoft.Extensions.Options;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Options;
using System.Net.Http.Headers;
using System.Web;

namespace MyThinkBook.Web.Services;

public interface IDropboxService
{
    public const string DropboxAccessTokenKey = "DropboxAccessToken";
    public const string DropboxExpiryDateKey = "DropboxExpiryDate";
    public const string DropboxBookmarkUrlKey = "DropboxBookmarkUrl";

    bool Oauth2TokenHasExpired { get; }

    string AuthorizeUrl { get; }

    Task ExchangeCodeForBearerTokenAsync(string code);

    Task<UsersGetCurrentAccountResponse?> GetCurrentAccountAsync();

    Task<int> BookmarkUrlAsync(string? url);

    Task<string?> GetBookmarkUrlAsync();

    Task<int> ClearBookmarkUrlAsync();
}

public class DropboxService : IDropboxService
{
    private readonly ILogger<DropboxService> logger;
    private readonly HttpClient httpClient;
    private readonly IAppStateItemRepository appStateItemRepository;
    //private readonly MyThinkBookDbContext myThinkBookDbContext;

    private readonly string authorizeUri;
    private readonly Uri apiBaseUri;

    private readonly string dropboxAppKey;
    private readonly string dropboxAppSecret;
    private readonly string dropboxRedirectUri;
    private readonly string auhorizeUrl;
    
    private Oauth2Token oauth2Token = new();

    public bool Oauth2TokenHasExpired
    {
        get => oauth2Token.HasExpired;
    }

    public string AuthorizeUrl => auhorizeUrl;

    public DropboxService(ILogger<DropboxService> logger, IConfiguration configuration, HttpClient httpClient, IAppStateItemRepository appStateItemRepository, IOptions<DropboxOptions> dropboxOptions)
    {
        this.logger = logger;
        this.httpClient = httpClient;
        this.appStateItemRepository = appStateItemRepository;
        //this.myThinkBookDbContext = myThinkBookDbContext; // Its too hard to mock DbContext 😥

        dropboxAppKey = dropboxOptions.Value.AppKey;
        dropboxAppSecret = dropboxOptions.Value.AppSecret;
        dropboxRedirectUri = dropboxOptions.Value.RedirectUrl;
        apiBaseUri = new Uri(dropboxOptions.Value.ApiBaseUrl);
        authorizeUri = dropboxOptions.Value.AuthorizeUrl;

        auhorizeUrl = GetAuthorizeUrl();

        Dictionary<string, string> dropboxAppStateItems = appStateItemRepository.KeyContains("Dropbox").ToDictionary(k => k.Key, v => v.Value);

        if (dropboxAppStateItems.ContainsKey(IDropboxService.DropboxAccessTokenKey) && dropboxAppStateItems.ContainsKey(IDropboxService.DropboxExpiryDateKey))
        {
            oauth2Token = new Oauth2Token
            {
                BearerAccessToken = dropboxAppStateItems[IDropboxService.DropboxAccessTokenKey],
                ExpiryDateTimeUtc = Convert.ToDateTime(dropboxAppStateItems[IDropboxService.DropboxExpiryDateKey])
            };
        }
    }

    public async Task<UsersGetCurrentAccountResponse?> GetCurrentAccountAsync()
    {
        //using (var dbx = new DropboxClient(oauth2Token.BearerAccessToken))
        //{
        //    var full = await dbx.Users.GetCurrentAccountAsync();
        //    Console.WriteLine("{0} - {1}", full.Name.DisplayName, full.Email);
        //}

        var uri = new Uri(apiBaseUri, "/2/users/get_current_account");

        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", oauth2Token.BearerAccessToken);

        var responseMessage = await httpClient.PostAsync(uri, null);

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonResponse = await responseMessage.Content.ReadFromJsonAsync<UsersGetCurrentAccountResponse>();

            return jsonResponse;
        }

        return null;
    }

    public async Task ExchangeCodeForBearerTokenAsync(string code)
    {
        var uri = new Uri(apiBaseUri, "/oauth2/token");

        var keyValuePairs = new Dictionary<string, string>
        {
            { "code", code },
            { "grant_type", "authorization_code" },
            { "client_id", dropboxAppKey },
            { "client_secret", dropboxAppSecret},
            { "redirect_uri", dropboxRedirectUri },
        }.ToList();

        var responseMessage = await httpClient.PostAsync(uri, new FormUrlEncodedContent(keyValuePairs));

        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonResponse = await responseMessage.Content.ReadFromJsonAsync<Oauth2TokenResponse>();

            if (jsonResponse != null)
            {
                oauth2Token = new Oauth2Token(jsonResponse);

                await AddOrUpdateDropboxAccessToken(oauth2Token);

                await AddOrUpdateDropboxExpiryDate(oauth2Token);

                await appStateItemRepository.SaveChangesAsync();
            }
        }

        // The equivalent of above using HttpRequestMessage
        //HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, uri);
        //requestMessage.Content = new FormUrlEncodedContent(keyValuePairs);
        //Console.WriteLine(requestMessage.Content.ReadAsStringAsync().Result);
        //Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(requestMessage));
        //var responseMessage = await httpClient.SendAsync(requestMessage);
    }

    private async Task AddOrUpdateDropboxExpiryDate(Oauth2Token oauth2Token)
    {
        var dropboxExpiryDate = await appStateItemRepository.KeyEqualsAsync(IDropboxService.DropboxExpiryDateKey);
            
        if (dropboxExpiryDate == null)
        {
            dropboxExpiryDate = new Domain.AppStateItem
            {
                Key = IDropboxService.DropboxExpiryDateKey,
                Value = oauth2Token.ExpiryDateTimeUtc.ToString()
            };

            appStateItemRepository.Add(dropboxExpiryDate);
        }
        else
        {
            dropboxExpiryDate.Value = oauth2Token.ExpiryDateTimeUtc.ToString();
        }
    }

    private async Task AddOrUpdateDropboxAccessToken(Oauth2Token oauth2Token)
    {
        var dropboxAccessToken = await appStateItemRepository.KeyEqualsAsync(IDropboxService.DropboxAccessTokenKey);

        if (dropboxAccessToken == null)
        {
            dropboxAccessToken = new Domain.AppStateItem
            {
                Key = IDropboxService.DropboxAccessTokenKey,
                Value = oauth2Token.BearerAccessToken
            };

            appStateItemRepository.Add(dropboxAccessToken);
        }
        else
        {
            dropboxAccessToken.Value = oauth2Token.BearerAccessToken;
        }
    }

    private string GetAuthorizeUrl()
    {
        UriBuilder builder = new(authorizeUri);
        var qs = HttpUtility.ParseQueryString(string.Empty);
        qs["client_id"] = dropboxAppKey;
        qs["response_type"] = "code";
        qs["redirect_uri"] = dropboxRedirectUri;
        builder.Query = qs.ToString();

        return builder.ToString();
    }

    public async Task<int> BookmarkUrlAsync(string? url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return 0;
        }

        var appStateItem = await appStateItemRepository.KeyEqualsAsync(IDropboxService.DropboxBookmarkUrlKey);

        if (appStateItem == null)
        {
            appStateItem = new AppStateItem
            {
                Key = IDropboxService.DropboxBookmarkUrlKey,
                Value = url
            };

            appStateItemRepository.Add(appStateItem);
        }
        else
        {
            appStateItem.Value = url;
        }

        return await appStateItemRepository.SaveChangesAsync();
    }

    public async Task<string?> GetBookmarkUrlAsync()
    {
        return (await appStateItemRepository.KeyEqualsAsync(IDropboxService.DropboxBookmarkUrlKey))?.Value;
    }

    public async Task<int> ClearBookmarkUrlAsync()
    {
        return await appStateItemRepository.DeleteAsync(IDropboxService.DropboxBookmarkUrlKey);
    }
}