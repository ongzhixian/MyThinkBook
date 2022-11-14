using Microsoft.AspNetCore.SignalR;
using MyThinkBook.Web.Areas.FxTrading.Models;
using MyThinkBook.Web.Hubs;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.HostedServices;

public class FxTradingListener : IHostedService
{
    private readonly ILogger<FxTradingListener> logger;
    private readonly IFxTradingEngineProxyService fxTradingEngingProxyService;
    private readonly System.Timers.Timer timer;
    private readonly IHubContext<FxTradingHub> fxTradingHubContext;

    public FxTradingListener(ILogger<FxTradingListener> logger, IFxTradingEngineProxyService fxTradingEngineProxyService, IHubContext<FxTradingHub> fxTradingHubContext)
    {
        this.logger = logger;
        this.fxTradingEngingProxyService = fxTradingEngineProxyService;
        this.fxTradingHubContext = fxTradingHubContext;

        timer = new System.Timers.Timer(new TimeSpan(0, 0, 4));
        timer.Elapsed += Timer_Elapsed;
        timer.AutoReset = true;
    }

    private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        _ = AsyncWorkWrapper();
        logger.LogTrace("FxTradingListener timer elapsed");
    }

    private async Task AsyncWorkWrapper()
    {
        await HealthProbeAsync();
        await GetInstrumentsAsync();
    }

    private async Task HealthProbeAsync()
    {
        var result = await fxTradingEngingProxyService.PingAsync();
        FxTradingStateModel.Instance.IsTradingProxyOnline = result == "OK";
        await fxTradingHubContext.Clients.All.SendAsync("TradingEngineStatus", "SYSTEM", FxTradingStateModel.Instance.IsTradingProxyOnline);
    }

    private async Task GetInstrumentsAsync()
    {
        if (FxTradingStateModel.Instance.InstrumentsExpired)
        {
            logger.LogInformation("Instruments expired; refreshing");
            var result = await fxTradingEngingProxyService.GetInstrumentsAsync();
            FxTradingStateModel.Instance.SetInstruments(result);
        }
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("FxTradingListener started.");
        timer.Enabled = true;
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("FxTradingListener stopped.");
        timer.Enabled = false;
        return Task.CompletedTask;
    }
}
