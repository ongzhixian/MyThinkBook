using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyThinkBook.Web.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThinkBook.Web.Hubs.Tests
{
    [TestClass()]
    public class FxTradingHubTests
    {
        [TestMethod()]
        public void SendTradingEngineStatusTest()
        {

            FxTradingHub hub = new FxTradingHub();

            Mock<IClientProxy> mockClientProxy = new Mock<IClientProxy>();
            Mock<IHubCallerClients> mockHubCallerClients = new Mock<IHubCallerClients>();
            mockHubCallerClients.Setup(m => m.All).Returns(mockClientProxy.Object);
            //mockClientProxy.Setup(m => m.SendCoreAsync(It.IsAny<string>(), It.IsAny<object[]>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);

            hub.Clients = mockHubCallerClients.Object;

            var result = hub.SendTradingEngineStatus("someUser", "someMessage");

            Assert.IsNotNull(result);
            //Assert.IsTrue(result.IsCompleted);
            mockClientProxy.Verify(m => m.SendCoreAsync(It.IsAny<string>(), It.IsAny<object[]>(), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}