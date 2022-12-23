using System.Text.Json.Serialization;

namespace MyThinkBook.Web.Domain.OandaApi;

public record Account
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("mt4AccountID")]
    public int? Mt4AccountID { get; set; }
}

public record AccountsResponse
{
    [JsonPropertyName("accounts")]
    public IEnumerable<Account> AccountList { get; set; } = new List<Account>();
}

//{
//    "account": {
//        "guaranteedStopLossOrderMode": "ALLOWED",
//        "hedgingEnabled": false,
//        "currency": "USD",
//        "createdByUserID": 11976008,
//        "alias": "MT4-Practice",
//        "marginRate": "0.1",
//        "lastTransactionID": "440",
//        "balance": "730.8327",
//        "openTradeCount": 0,
//        "openPositionCount": 0,
//        "pendingOrderCount": 0,
//        "pl": "-10.7317",
//        "resettablePL": "-10.7317",
//        "resettablePLTime": "0",
//        "financing": "0.0344",
//        "commission": "0.0000",
//        "dividendAdjustment": "0",
//        "guaranteedExecutionFees": "0.0000",
//        "unrealizedPL": "0.0000",
//        "NAV": "730.8327",
//        "marginUsed": "0.0000",
//        "marginAvailable": "730.8327",
//        "positionValue": "0.0000",
//        "marginCloseoutUnrealizedPL": "0.0000",
//        "marginCloseoutNAV": "730.8327",
//        "marginCloseoutMarginUsed": "0.0000",
//        "marginCloseoutPositionValue": "0.0000",
//        "marginCloseoutPercent": "0.00000",
//        "withdrawalLimit": "730.8327",
//        "marginCallMarginUsed": "0.0000",
//        "marginCallPercent": "0.00000"
//    },
//    "lastTransactionID": "440"
//}

public record AccountSummary
{
    [JsonPropertyName("balance")]
    public decimal Balance { get; set; }

    [JsonPropertyName("openTradeCount")]
    public int OpenTradeCount { get; set; }

    [JsonPropertyName("openPositionCount")]
    public int OpenPositionCount { get; set; }

    [JsonPropertyName("pendingOrderCount")]
    public int PendingOrderCount { get; set; }
}

public record AccountSummaryResponse
{
    [JsonPropertyName("account")]
    public AccountSummary AccountSummary { get; set; } = new();

    [JsonPropertyName("lastTransactionID")]
    public string LastTransactionId { get; set; } = string.Empty;
}

public record Instrument
{
    //"name": "NZD_CAD",
    //"type": "CURRENCY",
    //"displayName": "NZD/CAD",
    //"pipLocation": -4,
    //"displayPrecision": 5,
    //"tradeUnitsPrecision": 0,
    //"minimumTradeSize": "1",
    //"maximumTrailingStopDistance": "1.00000",
    //"minimumTrailingStopDistance": "0.00050",
    //"maximumPositionSize": "0",
    //"maximumOrderUnits": "100000000",
    //"marginRate": "0.1",
    //"guaranteedStopLossOrderMode": "ALLOWED",
    //"minimumGuaranteedStopLossDistance": "0.0010",
    //"guaranteedStopLossOrderExecutionPremium": "0.0005",

    [JsonPropertyName("name")]
    public string Code { get; set; } = string.Empty;

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("displayName")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("pipLocation")]
    public int PipLocation { get; set; }

    [JsonPropertyName("displayPrecision")]
    public int DisplayPrecision { get; set; }

    [JsonPropertyName("tradeUnitsPrecision")]
    public int TradeUnitsPrecision { get; set; }

    [JsonPropertyName("minimumTradeSize")]
    public string MinimumTradeSize { get; set; } = string.Empty;

    //"tags": [
    //    {
    //        "type": "ASSET_CLASS",
    //        "name": "CURRENCY"
    //    }
    //],

    [JsonPropertyName("tags")]
    public List<Tag> Tags { get; set; } = new List<Tag>();
}

public record Tag
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public record InstrumentsResponse
{
    [JsonPropertyName("instruments")]
    public IEnumerable<Instrument> InstrumentList { get; set; } = new List<Instrument>();

    [JsonPropertyName("lastTransactionID")]
    public string LastTransactionId { get; set; } = string.Empty;
}

public record Ohlc
{
    //"o": "1793.574",
    //"h": "1793.637",
    //"l": "1793.530",
    //"c": "1793.547"

    [JsonPropertyName("o")]
    public string Open { get; set; } = string.Empty;

    [JsonPropertyName("h")]
    public string High { get; set; } = string.Empty;

    [JsonPropertyName("l")]
    public string Low { get; set; } = string.Empty;

    [JsonPropertyName("c")]
    public string Close { get; set; } = string.Empty;

}

public record Candle
{
    //"complete": true,
    //"volume": 17,
    //"time": "2022-12-23T00:24:00.000000000Z",

    [JsonPropertyName("complete")]
    public bool Complete { get; set; }

    [JsonPropertyName("volume")]
    public int Volume { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; } = string.Empty;

    [JsonPropertyName("bid")]
    public Ohlc? Bid { get; set; }

    [JsonPropertyName("mid")]
    public Ohlc? Mid { get; set; }

    [JsonPropertyName("ask")]
    public Ohlc? Ask { get; set; }
}

public record InstrumentCandlesResponse
{
    [JsonPropertyName("instrument")]
    public string InstrumentCode { get; set; } = string.Empty;

    [JsonPropertyName("granularity")]
    public string Granularity { get; set; } = string.Empty;

    [JsonPropertyName("candles")]
    public IEnumerable<Candle> CandleList { get; set; } = new List<Candle>();
}