using Dropbox.Api;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Primitives;
using MyThinkBook.Web.Services;
using static Dropbox.Api.TeamLog.ActorLogInfo;

namespace MyThinkBook.Web.Infrastructure;


public class DropboxFileProvider : IDropboxFileProvider
{
    private readonly ILogger<DropboxFileProvider> logger;
    private readonly string accessToken;
    private const string accessTokenConfigurationKey = "dropbox:myThinkBook:accessToken";
    private readonly IServerAddressService serverAddressService;

    public DropboxFileProvider(ILogger<DropboxFileProvider> logger, IConfiguration configuration, IServerAddressService serverAddressService)
    {
        this.logger = logger;

        accessToken = configuration[accessTokenConfigurationKey] ?? throw new ArgumentNullException(nameof(configuration), accessTokenConfigurationKey);

        this.serverAddressService = serverAddressService;

        foreach (var address in serverAddressService.GetServerAddresses())
        {
            logger.LogInformation("Kestrel is listening on {address}", address);
        }
    }

    public async Task TestAsync()
    {
        //private readonly Uri RedirectUri = new Uri(LoopbackHost + "authorize");
        //DropboxOAuth2Helper.GetAuthorizeUri(OAuthResponseType.Token, ApiKey, RedirectUri, state: state);

        using (var dbx = new DropboxClient(accessToken))
        {
            var full = await dbx.Users.GetCurrentAccountAsync();
            Console.WriteLine("{0} - {1}", full.Name.DisplayName, full.Email);
        }
    }

    public IDirectoryContents GetDirectoryContents(string subpath)
    {
        throw new NotImplementedException();
    }

    public IFileInfo GetFileInfo(string subpath)
    {
        throw new NotImplementedException();
    }

    public IChangeToken Watch(string filter)
    {
        throw new NotImplementedException();
    }
}
