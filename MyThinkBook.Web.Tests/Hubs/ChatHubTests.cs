using Microsoft.AspNetCore.SignalR;
using Moq;

namespace MyThinkBook.Web.Hubs.Tests
{
    [TestClass()]
    public class ChatHubTests
    {
        [TestMethod()]
        public void SendMessageTest()
        {
            ChatHub hub = new();

            Mock<IClientProxy> mockClientProxy = new();
            Mock<IHubCallerClients> mockHubCallerClients = new();
            mockHubCallerClients.Setup(m => m.All).Returns(mockClientProxy.Object);
            mockClientProxy.Setup(m => m.SendCoreAsync(It.IsAny<string>(), It.IsAny<object[]>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);

            hub.Clients = mockHubCallerClients.Object;

            var result = hub.SendMessage("someUser", "someMessage");

            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsCompleted);
        }
    }

    //public static Mock<HubConnection> Get()
    //{
    //    IConnectionFactory connectionFactory = new Mock<IConnectionFactory>().Object;
    //    IHubProtocol protocol = new Mock<IHubProtocol>().Object;
    //    EndPoint endPoint = new Mock<EndPoint>().Object;
    //    IServiceProvider serviceProvider = new Mock<IServiceProvider>().Object;
    //    ILoggerFactory loggerFactory = null;
    //    return new Mock<HubConnection>(MockBehavior.Strict,
    //        connectionFactory, protocol, endPoint, serviceProvider, loggerFactory);
    //}
}