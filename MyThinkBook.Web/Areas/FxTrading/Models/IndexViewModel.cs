namespace MyThinkBook.Web.Areas.FxTrading.Models;

public class TradeOrder
{
    public int Id { get; set; }
}

public class IndexViewModel
{
    public int OpportunitiesCount { get; set; }

    public bool IsTradingProxyOnline { get; set; }

    public IList<TradeOrder> ActiveTrades { get; set; } = new List<TradeOrder>();

    public IList<TradeOrder> PendingTrades { get; set; } = new List<TradeOrder>();

    public IndexViewModel()
    {
        this.IsTradingProxyOnline = FxTradingStateModel.Instance.IsTradingProxyOnline;
    }
}