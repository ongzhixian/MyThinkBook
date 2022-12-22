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