using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace MyThinkBook.Web.Services;

public interface IServerAddressService
{
    ICollection<string> GetServerAddresses();
}

public class ServerAddressService : IServerAddressService
{
    private readonly ILogger<ServerAddressService> logger;
    private readonly IServer server;

    private readonly ICollection<string> emptyAddressCollection = new Collection<string>().ToImmutableArray();

    public ServerAddressService(ILogger<ServerAddressService> logger, IServer server)
    {
        this.logger = logger;
        this.server = server;
    }

    public ICollection<string> GetServerAddresses()
    {
        var addressFeature = server.Features.Get<IServerAddressesFeature>();

        var result = (addressFeature?.Addresses ?? emptyAddressCollection).OrderBy(r => r).ToImmutableArray();

        logger.LogInformation("Addresses {addresses}", result);

        return result;
    }
}
