using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using MyThinkBook.Web.Domain.OandaApi;
using MyThinkBook.Web.Options;
using System.Net.Http.Headers;

namespace MyThinkBook.Web.Services;

public interface IOandaRestApiService
{
    Task<AccountsResponse> GetAccountsAsync();

    Task<AccountSummaryResponse> GetAccountSummaryAsync(string accountId);
}


public class OandaRestApiService : IOandaRestApiService
{
    private readonly ILogger<OandaRestApiService> logger;
    private readonly HttpClient httpClient;

    public OandaRestApiService(ILogger<OandaRestApiService> logger, HttpClient httpClient, IOptions<OandaOptions> oandaOptions)
    {
        this.logger = logger;
        this.httpClient = httpClient;

        this.httpClient.BaseAddress = new Uri(oandaOptions.Value.RestApiUrl);
        this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", oandaOptions.Value.ApiKey);

        this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //oandaOptions.Value.RestApiUrl
        //oandaOptions.Value.StreamingApiUrl
        //oandaOptions.Value.AccountNumber
        //oandaOptions.Value.ApiKey
    }

    public async Task<AccountsResponse> GetAccountsAsync()
    {
        return await this.httpClient.GetFromJsonAsync<AccountsResponse>("/v3/accounts") ?? new();
    }

    public async Task<AccountSummaryResponse> GetAccountSummaryAsync(string accountId)
    {
        return await this.httpClient.GetFromJsonAsync<AccountSummaryResponse>($"/v3/accounts/{accountId}/summary") ?? new();
    }
}
