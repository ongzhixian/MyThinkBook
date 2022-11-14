using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Hubs;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.HealthChecks.Tests
{
    [TestClass()]
    public class FxTradingEngineProxyHealthCheckTests
    {
        private readonly Mock<ILogger<FxTradingEngineProxyHealthCheck>> mocklogger = new();
        private readonly Mock<IFxTradingEngineProxyService> fxTradingEngineProxyService = new();
        private readonly Mock<IHubContext<FxTradingHub>> mockFxTradingHubContext = new();
        private readonly Mock<IHubClients> hubClients = new();
        private readonly Mock<IClientProxy> clientProxy = new();

        [TestInitialize]
        public void InitializeTest()
        {
            mockFxTradingHubContext.Setup(m => m.Clients).Returns(hubClients.Object);
            hubClients.Setup(m => m.All).Returns(clientProxy.Object);
            clientProxy.Setup(m => m.SendCoreAsync(It.IsAny<string>(), It.IsAny<object[]>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        }

        [TestMethod()]
        public void FxTradingEngineProxyHealthCheckTest()
        {
            FxTradingEngineProxyHealthCheck healthCheck = new(mocklogger.Object, fxTradingEngineProxyService.Object, mockFxTradingHubContext.Object);

            Assert.IsNotNull(healthCheck);
        }

        [TestMethod()]
        public async Task CheckHealthAsyncTest_WhenPingOk()
        {
            fxTradingEngineProxyService.Setup(m => m.PingAsync()).ReturnsAsync("OK");

            var healthCheck = new FxTradingEngineProxyHealthCheck(mocklogger.Object, fxTradingEngineProxyService.Object, mockFxTradingHubContext.Object);

            HealthCheckResult healthCheckResult = await healthCheck.CheckHealthAsync(new HealthCheckContext());

            Assert.IsTrue(healthCheckResult.Status == HealthStatus.Healthy);
        }

        [TestMethod()]
        public async Task CheckHealthAsyncTest_WhenPingFail()
        {
            fxTradingEngineProxyService.Setup(m => m.PingAsync()).ReturnsAsync(string.Empty);

            var healthCheck = new FxTradingEngineProxyHealthCheck(mocklogger.Object, fxTradingEngineProxyService.Object, mockFxTradingHubContext.Object);

            HealthCheckResult healthCheckResult = await healthCheck.CheckHealthAsync(new HealthCheckContext());

            Assert.IsTrue(healthCheckResult.Status == HealthStatus.Unhealthy);
        }
    }
}