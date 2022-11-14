using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyThinkBook.Web.Domain.FxTrading;

[Table("trade_instrument")]
public record TradeInstrument
{
    [Key]
    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("display_name")]
    public string DisplayName { get; set; } = string.Empty;

    [Column("type")]
    public string Type { get; set; } = string.Empty;

    [Column("asset_class")]
    public string AssetClass { get; set; } = string.Empty;

    [Column("minimum_trade_size")]
    public decimal MinimumTradeSize { get; set; }
}