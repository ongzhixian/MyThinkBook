using MyThinkBook.Web.Areas.FxTrading.Models;
using System.Collections.Immutable;
using System.Net.Sockets;

namespace MyThinkBook.Web.Services;

public interface IFxTradingEngineProxyService
{
    Task<IList<Instrument>> GetInstrumentsAsync();
    Task<string> PingAsync();
}

public class FxTradingEngineProxyService : IFxTradingEngineProxyService
{
    private const string fxTradingEngineProxyServiceUrlConfigKey = "FxTradingEngineProxyService:Url";
    private readonly ILogger<FxTradingEngineProxyService> logger;
    private readonly HttpClient httpClient;
    private readonly IList<Instrument> emptyInstrumentList = new List<Instrument>().ToImmutableList();
    

    public FxTradingEngineProxyService(ILogger<FxTradingEngineProxyService> logger, IConfiguration configuration, HttpClient httpClient)
    {
        var fxTradingEngineProxyServiceUrl = configuration[fxTradingEngineProxyServiceUrlConfigKey] ?? throw new ArgumentNullException(nameof(configuration), $"configuration key [{fxTradingEngineProxyServiceUrlConfigKey}] not found.");
        ArgumentException.ThrowIfNullOrEmpty(fxTradingEngineProxyServiceUrl);

        this.logger = logger;
        this.httpClient = httpClient;
        this.httpClient.BaseAddress = new Uri(fxTradingEngineProxyServiceUrl);

        // using Microsoft.Net.Http.Headers;
        //this.httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/vnd.github.v3+json");
        //this.httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");
    }

    public async Task<string> PingAsync()
    {
        try
        {
            return await httpClient.GetStringAsync("api/health");
        }
        catch (HttpRequestException ex)
        {
            if (ex.InnerException is SocketException exception && exception.SocketErrorCode == SocketError.ConnectionRefused)
            {
                logger.LogWarning("Connection to FxTradingEngine proxy was refused.");
            }
            else
            {
                logger.LogWarning(ex, "HttpRequestException occur while pinging health");
            }
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "Exception occur while pinging health");
        }

        return string.Empty;
    }

    public async Task<IList<Instrument>> GetInstrumentsAsync()
    {
        try
        {
            List<Instrument>? instruments = await httpClient.GetFromJsonAsync<List<Instrument>>("api/instrument");

            return instruments ?? emptyInstrumentList;
        }
        catch (HttpRequestException ex)
        {
            if (ex.InnerException is SocketException exception && exception.SocketErrorCode == SocketError.ConnectionRefused)
            {
                logger.LogInformation("Connection to FxTradingEngine proxy was refused.");
            }
            else
            {
                logger.LogWarning(ex, "HttpRequestException occur while pinging health");
            }
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "Exception occur while pinging health");
        }

        return new List<Instrument>();
    }
}
