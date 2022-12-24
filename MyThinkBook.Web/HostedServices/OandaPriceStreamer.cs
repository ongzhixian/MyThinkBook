using MyThinkBook.Web.Services;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace MyThinkBook.Web.HostedServices;

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
