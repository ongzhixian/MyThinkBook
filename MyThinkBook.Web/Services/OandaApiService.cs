using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using MyThinkBook.Web.Domain.OandaApi;
using MyThinkBook.Web.Options;
using System.Net.Http.Headers;

namespace MyThinkBook.Web.Services;

public interface IOandaRestApiService
{
    Task<AccountsResponse> GetAccountsAsync();

    Task<AccountSummaryResponse> GetAccountSummaryAsync();

    Task<InstrumentsResponse> GetInstrumentsAsync();
}


public class OandaRestApiService : IOandaRestApiService
{
    private readonly ILogger<OandaRestApiService> logger;
    private readonly HttpClient httpClient;
    private readonly string accountNumber;
    private readonly IMemoryCache memoryCache;

    public OandaRestApiService(ILogger<OandaRestApiService> logger, HttpClient httpClient, IOptions<OandaOptions> oandaOptions, IMemoryCache memoryCache)
    {
        this.logger = logger;
        this.httpClient = httpClient;

        this.httpClient.BaseAddress = new Uri(oandaOptions.Value.RestApiUrl);
        this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", oandaOptions.Value.ApiKey);

        this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
        //{
        //    NoCache = true
        //};

        //oandaOptions.Value.RestApiUrl
        //oandaOptions.Value.StreamingApiUrl
        //oandaOptions.Value.AccountNumber
        //oandaOptions.Value.ApiKey
        this.accountNumber = oandaOptions.Value.AccountNumber;

        this.memoryCache = memoryCache;
    }

    public async Task<AccountsResponse> GetAccountsAsync()
    {
        return await this.httpClient.GetFromJsonAsync<AccountsResponse>("/v3/accounts") ?? new();
    }

    public async Task<AccountSummaryResponse> GetAccountSummaryAsync()
    {
        return await this.httpClient.GetFromJsonAsync<AccountSummaryResponse>($"/v3/accounts/{accountNumber}/summary") ?? new();
    }

    public async Task<InstrumentsResponse> GetInstrumentsAsync()
    {
        memoryCache.TryGetValue<InstrumentsResponse>(nameof(InstrumentsResponse), out var instrumentsResponse);

        logger.LogInformation("Get instruments from memory cache");

        return instrumentsResponse ?? await RetrieveInstrumentsAsync();
    }

    private async Task<InstrumentsResponse> RetrieveInstrumentsAsync()
    {
        var instrumentsResponse = await this.httpClient.GetFromJsonAsync<InstrumentsResponse>($"/v3/accounts/{accountNumber}/instruments");

        MemoryCacheEntryOptions options = new()
        {
            SlidingExpiration = TimeSpan.FromHours(1)
        };

        memoryCache.Set<InstrumentsResponse>(nameof(InstrumentsResponse), instrumentsResponse, options);

        logger.LogInformation("Add retrieved instruments to memory cache");

        return instrumentsResponse ?? new InstrumentsResponse();
    }
}
