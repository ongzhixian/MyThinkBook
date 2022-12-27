using System.Text.Json.Serialization;

namespace MyThinkBook.Web.Domain;

public record SgxInstrument
{
    public string Name { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;
    
    public string Isin { get; set; } = string.Empty;
    
    public string Code { get; set; } = string.Empty;
    
    public string Counter { get; set; } = string.Empty;
}

public record MarketMetadata
{
    //"fisn": "UOB LTD/ORDSHS",
    //"issuerName": "UNITED OVERSEAS BANK LIMITED",
    //"maturityDate": null,
    //"ibmCode": "1M31",

    // Financial Instrument Short Name (FISN)
    [JsonPropertyName("fisn")]
    public string FinancialInstrumentShortName { get; set; } = string.Empty;
    [JsonPropertyName("issuerName")]
    public string IssuerName { get; set; } = string.Empty;
    [JsonPropertyName("maturityDate")]
    public string? MaturityDate { get; set; } = string.Empty;
    [JsonPropertyName("ibmCode")]
    public string IbmCode { get; set; } = string.Empty;

    //"chineseName": "大华银行",
    //"fullName": null,
    //"stockCode": "U11",
    //"isinCode": "SG1M31001969"

    [JsonPropertyName("chineseName")]
    public string ChineseName { get; set; } = string.Empty;
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }= string.Empty;
    [JsonPropertyName("stockCode")]
    public string StockCode { get; set; } = string.Empty;
    [JsonPropertyName("isinCode")]
    public string IsinCode { get; set; } = string.Empty;
}

public record MarketMetadataResponse
{
    [JsonPropertyName("data")]
    public List<MarketMetadata> MarketMetadataList { get; set; } = new List<MarketMetadata>();
}

public record PriceDataPoint
{
    //"nc": "D05",
    //"trading_time": "20110103_000000",
    //"o": 14.42,
    //"h": 14.54,
    //"l": 14.42,
    //"lt": 14.5,
    //"vl": 3599,
    //"pv": 0,
    //"v": 52163240,

    [JsonPropertyName("nc")]
    public string Code { get; set; } = string.Empty;

    [JsonPropertyName("trading_time")]
    public string TradingTime { get; set; } = string.Empty;

    [JsonPropertyName("o")]
    public decimal Open { get; set; }

    [JsonPropertyName("h")]
    public decimal High { get; set; }

    [JsonPropertyName("l")]
    public decimal Low { get; set; }

    [JsonPropertyName("lt")]
    public decimal Close { get; set; }

    [JsonPropertyName("vl")]
    public decimal Volume { get; set; }

}


public record SecurityPriceChartData
{
    [JsonPropertyName("historic")]
    public List<PriceDataPoint> PriceDataPointList { get; set; } = new List<PriceDataPoint>();
}

public record SecuritiesChartsResponse
{
    [JsonPropertyName("data")]
    public SecurityPriceChartData SecurityPriceChartData { get; set; } = new SecurityPriceChartData();
}
