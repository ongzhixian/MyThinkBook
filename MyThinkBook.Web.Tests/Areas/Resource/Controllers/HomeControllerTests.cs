using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Areas.Resource.Controllers;
using MyThinkBook.Web.Areas.Resource.Models;
using Microsoft.AspNetCore.Mvc.Routing;

namespace MyThinkBook.Web.Tests.Areas.Resource.Controllers;

[TestClass()]
public class HomeControllerTests
{
    private readonly Mock<ILogger<HomeController>> mockLogger = new();

    [TestMethod()]
    public void HomeControllerTest()
    {
        var controller = new HomeController(mockLogger.Object);

        Assert.IsNotNull(controller);
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
    public void IndexTest_WhenSearchModel()
    {
        var searchModel = new SearchModel
        {
            SearchTerm = "someSearchTerm",
            CloudResources = new List<Web.Areas.Resource.Models.Resource>(),
            LocalResources = new List<Web.Areas.Resource.Models.Resource>()
        };

        Mock<IUrlHelper> mockUrlHelper = new();
        mockUrlHelper.Setup(m => m.Action(It.IsAny<UrlActionContext>())).Returns("someUrl");

        var controller = new HomeController(mockLogger.Object);
        controller.Url = mockUrlHelper.Object;

        var result = controller.Index(searchModel);

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }
}