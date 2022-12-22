namespace MyThinkBook.Web.Areas.FxTrading.Models;
public class FxTradingStateModel
{
    static FxTradingStateModel()
    {
        
    }

    private FxTradingStateModel()
    {
        InstrumentsExpiryDateTime = DateTime.UtcNow;
        instruments = new List<XxxInstrument>();
    }

    public static FxTradingStateModel Instance
    {
        get
        {
            return instance;
        }
    }

    private static readonly FxTradingStateModel instance = new();

    public int OpportunitiesCount { get; set; }

    public bool IsTradingProxyOnline { get; set; }

    public IList<TradeOrder> ActiveTrades { get; set; } = new List<TradeOrder>();

    public IList<TradeOrder> PendingTrades { get; set; } = new List<TradeOrder>();

    public IList<XxxInstrument> Instruments => instruments;

    private IList<XxxInstrument> instruments;

    public bool InstrumentsExpired
    {
        get
        {
            return DateTime.UtcNow > InstrumentsExpiryDateTime;
        }
    }

    public DateTime InstrumentsExpiryDateTime { get; private set; }

    public void SetInstruments(IList<XxxInstrument> instruments, DateTime? expiryDateTime = null)
    {
        this.instruments = instruments;
        InstrumentsExpiryDateTime = expiryDateTime ?? DateTime.UtcNow.AddDays(1);
    }
}
