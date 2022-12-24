using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.HostedServices;

// Probably don't need this; we simply run the stream service as an API

public class OandaPriceStreamer : IHostedService
{
    private readonly ILogger<OandaPriceStreamer> logger;

    private readonly IOandaStreamApiService oandaStreamApiService;

    private Task? streamTask;

    public bool IsActive{ get; private set; }

    public OandaPriceStreamer(ILogger<OandaPriceStreamer> logger, IOandaStreamApiService oandaStreamApiService)
    {
        this.logger = logger;

        this.oandaStreamApiService = oandaStreamApiService;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        //streamTask = oandaStreamApiService.StreamPriceAsync();

        IsActive = true;

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        IsActive = false;

        return Task.CompletedTask;
    }
}
