using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MyThinkBook.Web.Areas.FxTrading.Models;
using MyThinkBook.Web.Hubs;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.HealthChecks;

// Reference: https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-7.0

public class FxTradingEngineProxyHealthCheck : IHealthCheck
{
    private readonly ILogger<FxTradingEngineProxyHealthCheck> logger;
    private readonly IFxTradingEngineProxyService fxTradingEngineProxyService;
    private readonly IHubContext<FxTradingHub> fxTradingHubContext;

    public FxTradingEngineProxyHealthCheck(ILogger<FxTradingEngineProxyHealthCheck> logger, 
        IFxTradingEngineProxyService fxTradingEngineProxyService,
        IHubContext<FxTradingHub> fxTradingHubContext)
    {
        this.logger = logger;
        this.fxTradingEngineProxyService = fxTradingEngineProxyService;
        this.fxTradingHubContext = fxTradingHubContext;
    }

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        var result = await fxTradingEngineProxyService.PingAsync();

        FxTradingStateModel.Instance.IsTradingProxyOnline = result == "OK";

        await fxTradingHubContext.Clients.All.SendAsync("TradingEngineStatus", "SYSTEM", FxTradingStateModel.Instance.IsTradingProxyOnline, cancellationToken: cancellationToken);

        if (FxTradingStateModel.Instance.IsTradingProxyOnline)
        {
            logger.LogDebug("FxTradingEngine proxy service is healthy.");

            return HealthCheckResult.Healthy("FxTradingEngine proxy service is healthy.");
        }

        return HealthCheckResult.Unhealthy("FxTradingEngine proxy service health check failed.");
    }
}