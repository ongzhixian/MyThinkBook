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
