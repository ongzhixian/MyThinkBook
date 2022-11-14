using MyThinkBook.Web.Areas.FxTrading.Models;

namespace MyThinkBook.Web.Services
{
    public interface IFxTradingEngineProxyService
    {
        Task<IList<Instrument>> GetInstrumentsAsync();
        Task<string> PingAsync();
    }
}