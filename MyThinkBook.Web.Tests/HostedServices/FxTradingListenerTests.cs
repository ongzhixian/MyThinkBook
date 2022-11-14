using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Hubs;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.HostedServices.Tests
{
    //[TestClass()]
    //public class FxTradingListenerTests
    //{
    //    private readonly Mock<ILogger<FxTradingListener>> mockLogger = new();
    //    private readonly Mock<IFxTradingEngineProxyService> fxTradingEngineProxyService = new();
    //    private readonly Mock<IHubContext<FxTradingHub>> fxTradingHubContext = new();

    //    [TestMethod()]
    //    public void FxTradingListenerTest()
    //    {
    //        var fxTradingListener = new FxTradingListener(mockLogger.Object, fxTradingEngineProxyService.Object, fxTradingHubContext.Object);

    //        Assert.IsNotNull(fxTradingListener);
    //    }

    //    [TestMethod()]
    //    public void StartAsyncTest()
    //    {
    //        var fxTradingListener = new FxTradingListener(mockLogger.Object, fxTradingEngineProxyService.Object, fxTradingHubContext.Object);

    //        var task = fxTradingListener.StartAsync(new CancellationToken());
            
    //        Assert.IsTrue(task.IsCompleted);
    //    }

    //    [TestMethod()]
    //    public void StopAsyncTest()
    //    {
    //        var fxTradingListener = new FxTradingListener(mockLogger.Object, fxTradingEngineProxyService.Object, fxTradingHubContext.Object);

    //        var task = fxTradingListener.StopAsync(new CancellationToken());

    //        Assert.IsTrue(task.IsCompleted);
    //    }
    //}
}