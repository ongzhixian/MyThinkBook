using Microsoft.AspNetCore.SignalR;

namespace MyThinkBook.Web.Hubs;

public class FxTradingHub : Hub
{
    public async Task SendTradingEngineStatus(string user, string message)
    {
        await Clients.All.SendAsync("TradingEngineStatus", user, message);
    }
}