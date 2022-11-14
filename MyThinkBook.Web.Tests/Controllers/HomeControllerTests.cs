using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace MyThinkBook.Web.Controllers.Tests;

[TestClass()]
public class HomeControllerTests
{
    private readonly Mock<ILogger<HomeController>> mockLogger = new();

    [TestMethod()]
    public void HomeControllerTest()
    {
        var result = new HomeController(mockLogger.Object);
        
        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(HomeController));
    }

    [TestMethod()]
    public void IndexTest()
    {
        var controller = new HomeController(mockLogger.Object);

        var result = controller.Index();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod()]
    public async Task PrivacyTestAsync()
    {
        //Mock<HttpContext> mockHttpContext = new();
        //mockHttpContext.Setup(m => m.SignInAsync())

        var controller = new HomeController(mockLogger.Object);

        // Test mock HttpContext!?
        controller.ControllerContext = new ControllerContext();
        controller.ControllerContext.HttpContext = new DefaultHttpContext();
        controller.ControllerContext.HttpContext.User = new System.Security.Claims.ClaimsPrincipal();
        //controller.ControllerContext.HttpContext = mockHttpContext.Object;

        var result = await controller.PrivacyAsync();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod()]
    public void ErrorTest()
    {
        var controller = new HomeController(mockLogger.Object);

        var result = controller.Error();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
}