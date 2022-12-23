using MyThinkBook.Web.Domain.OandaApi;
using MyThinkBook.Web.Models;

namespace MyThinkBook.Web.Areas.FxTrading.Models;

public class InstrumentViewModel
{
    public string InstrumentCode { get; set; } = string.Empty;

    public string InstrumentName { get; set; } = string.Empty;

    public string OhlcJson { get; set; } = string.Empty;
}
