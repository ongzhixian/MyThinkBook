using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Moq;

namespace MyThinkBook.Web.Services.Tests
{
    //[TestClass()]
    //public class ServerAddressServiceTests
    //{
    //    private readonly Mock<ILogger<ServerAddressService>> mockLogger = new();
    //    private readonly Mock<IServer> mockServer = new();
    //    private readonly Mock<IFeatureCollection> mockFeatureCollection = new();
    //    private readonly Mock<IServerAddressesFeature> mockServerAddressesFeature = new();

    //    [TestMethod()]
    //    public void ServerAddressServiceTest()
    //    {
    //        var service = new ServerAddressService(mockLogger.Object, mockServer.Object);

    //        Assert.IsNotNull(service);
    //    }

    //    [TestMethod()]
    //    public void GetServerAddressesTest()
    //    {
    //        var stringCollection = new List<string>()
    //        {
    //            "address1", "address2"
    //        };
            
    //        mockServerAddressesFeature.Setup(m => m.Addresses).Returns(stringCollection);
    //        mockFeatureCollection.Setup(m => m.Get<IServerAddressesFeature>()).Returns(mockServerAddressesFeature.Object);
    //        mockServer.Setup(m => m.Features).Returns(mockFeatureCollection.Object);
    //        var service = new ServerAddressService(mockLogger.Object, mockServer.Object);

    //        var addresses = service.GetServerAddresses();

    //        Assert.IsNotNull(addresses);
    //        Assert.IsTrue(addresses.Contains("address1"));
    //        Assert.IsTrue(addresses.Contains("address2"));
    //    }
    //}
}