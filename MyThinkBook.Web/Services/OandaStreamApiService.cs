using Microsoft.Extensions.Options;
using MyThinkBook.Web.Domain.OandaApi;
using MyThinkBook.Web.Options;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http.Headers;

namespace MyThinkBook.Web.Services;

public interface IOandaStreamApiService
{
    //Task StreamPriceAsync();

    void SubscribePrice(string instrumentCode);

    void UnsubscribePrice(string instrumentCode);
}

public class OandaStreamApiService : IOandaStreamApiService
{
    private readonly string accountNumber;
    private readonly ILogger<OandaStreamApiService> logger;
    private readonly HttpClient httpClient;
    private readonly ObservableCollection<string> instrumentCodes = new ObservableCollection<string>();
    private Task? streamPriceTask = null;
    private CancellationTokenSource? cancellationTokenSource = null;


    public OandaStreamApiService(ILogger<OandaStreamApiService> logger, HttpClient httpClient, IOptions<OandaOptions> oandaOptions)
    {
        this.logger = logger;
        this.httpClient = httpClient;

        this.httpClient.BaseAddress = new Uri(oandaOptions.Value.StreamingApiUrl);
        this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", oandaOptions.Value.ApiKey);

        this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/octet-stream"));
        //httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
        //{
        //    NoCache = true
        //};

        //oandaOptions.Value.RestApiUrl
        //oandaOptions.Value.StreamingApiUrl
        //oandaOptions.Value.AccountNumber
        //oandaOptions.Value.ApiKey
        this.accountNumber = oandaOptions.Value.AccountNumber;

        instrumentCodes.CollectionChanged += InstrumentCodes_CollectionChanged;
    }

    private void InstrumentCodes_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        if (cancellationTokenSource != null)
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
            cancellationTokenSource = null;
        }

        if (streamPriceTask != null)
        {
            if (new TaskStatus[] { TaskStatus.RanToCompletion, TaskStatus.Faulted, TaskStatus.Canceled }.Contains(streamPriceTask.Status))
            {
                streamPriceTask.Dispose();
            }
            
            streamPriceTask = null;
        }

        cancellationTokenSource = new CancellationTokenSource();

        streamPriceTask = SubscribeToPriceStreamAsync(cancellationTokenSource.Token);
    }

    private async Task SubscribeToPriceStreamAsync(CancellationToken cancellationToken)
    {
        string urlEncodedInstrumentCodes = WebUtility.UrlEncode(string.Join(',', instrumentCodes));

        using var responseStream = await this.httpClient.GetStreamAsync($"/v3/accounts/{accountNumber}/pricing/stream?instruments={urlEncodedInstrumentCodes}", cancellationToken);

        // Method 1: 

        using StreamReader sr = new(responseStream);

        while (!cancellationToken.IsCancellationRequested)
        {
            var responseContent = await sr.ReadLineAsync(cancellationToken);

            if (responseContent == null)
            {
                continue;
            }

            var priceObject = System.Text.Json.JsonSerializer.Deserialize<PriceStreamResponse>(responseContent);

            // TODO: Fire

            logger.LogInformation("Content: [{content}]", responseContent);
        }

        // Method 2: Using DeserializeAsyncEnumerable ; not working

        //System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions(System.Text.Json.JsonSerializerDefaults.Web);
        //var values = System.Text.Json.JsonSerializer.DeserializeAsyncEnumerable<PriceStreamResponse>(responseStream, options, cancellationToken);
        //while (!cancellationToken.IsCancellationRequested)
        //{
        //    try
        //    {
        //        await foreach (var item in values)
        //        {
        //            logger.LogInformation("Content: [{content}]", item);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }

    public void SubscribePrice(string instrumentCode)
    {
        if (instrumentCodes.Contains(instrumentCode))
        {
            return;
        }

        instrumentCodes.Add(instrumentCode);
    }

    public void UnsubscribePrice(string instrumentCode)
    {
        if (!instrumentCodes.Contains(instrumentCode))
        {
            return;
        }

        instrumentCodes.Remove(instrumentCode);
    }
}
