using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Areas.FxTrading.Models;

public class OrderEntry
{
    [Required]
    [Display(Name = "Order type")]
    public OrderType OrderType { get; set; } = OrderType.BuyLimit;

    [Required]
    public decimal Quantity { get; set; }

    [Required]
    [Display(Name = "Symbol")]
    public string InstrumentCode { get; set; } = string.Empty;

    [Display(Name = "Limit price")]
    public decimal LimitPrice { get; set; }

    [Display(Name = "Stop loss")]
    public decimal StopLossPrice { get; set; }

    [Display(Name = "Take profit")]
    public decimal TakeProfitPrice { get; set; }

    [Required]
    [Display(Name = "Time in force")]
    public TimeInForce TimeInForce { get; set; } = TimeInForce.Gtc;

    [Required]
    [Display(Name = "Position fill")]
    public PositionFill PositionFill { get; set; } = PositionFill.Default;

    [Display(Name = "Clear form on submit")]
    public bool ClearFormOnSubmit { get; set; } = false;
}

public enum OrderType
{
    Market,
    [Display(Name = "Buy limit")]
    BuyLimit,
    [Display(Name = "Sell limit")]
    SellLimit,
    [Display(Name = "Buy stop")]
    BuyStop,
    [Display(Name = "Sell stop")]
    SellStop
}

public enum TimeInForce
{
    
    [Display(Name = "Good unTil Cancelled")]
    Gtc,
    [Display(Name = "Good unTil Date")]
    Gtd,
    [Display(Name = "Good For Day")]
    Gfd,
    [Display(Name = "Filled Or Killed")]
    Fok,
    [Display(Name = "Immediately partially filled Or Cancelled")]
    Ioc
}

public enum PositionFill
{
    Default,
    [Display(Name = "Open only")]
    Open_Only,
    [Display(Name = "Reduce first")]
    Reduce_First,
    [Display(Name = "Reduce only")]
    Reduce_Only
}
