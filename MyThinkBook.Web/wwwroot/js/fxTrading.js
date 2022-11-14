"use strict";

const connection = new signalR.HubConnectionBuilder()
    .withUrl("/fxTradingHub")
    .configureLogging(signalR.LogLevel.Debug)
    .build();

//Disable the send button until connection is established.
/*document.getElementById("sendButton").disabled = true;*/

connection.on("TradingEngineStatus", function (user, message) {
    console.log("Receive TradingEngineStatus", message);
    
    const tradingEngineNotificationValue = document.querySelector("#tradingEngineNotification > div.value");

    if (message == false) {
        tradingEngineNotificationValue.innerHTML = '<span style="color:red">&cross;</span>';
    } else {
        tradingEngineNotificationValue.innerHTML = '<span style="color:green">&check;</span>';
    }
});

connection.start().then(function () {
    console.info("Open connection to /fxTradingHub");
}).catch(function (err) {
    return console.error(err.toString());
});