using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.Areas.FxTrading.Controllers.Tests;

[TestClass()]
public class DocumentControllerTests
{
    private readonly Mock<ILogger<DocumentController>> mockLogger = new();
    private readonly Mock<IDropboxService> mockDropboxService = new();

    [TestMethod()]
    public void DocumentControllerTest()
    {
        var controller = new DocumentController(mockLogger.Object, mockDropboxService.Object);

        Assert.IsNotNull(controller);
    }

    [TestMethod()]
    public async Task IndexAsyncTestAsync_WhenOauth2TokenHasExpiredIsFalse()
    {
        mockDropboxService.Setup(m => m.Oauth2TokenHasExpired).Returns(false);
        mockDropboxService.Setup(m => m.GetCurrentAccountAsync()).ReturnsAsync(new UsersGetCurrentAccountResponse());

        var controller = new DocumentController(mockLogger.Object, mockDropboxService.Object);

        var result = await controller.IndexAsync();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod()]
    public async Task IndexAsyncTestAsync_WhenOauth2TokenHasExpiredIsTrue()
    {
        mockDropboxService.Setup(m => m.Oauth2TokenHasExpired).Returns(true);
        mockDropboxService.Setup(m => m.GetCurrentAccountAsync()).ReturnsAsync(new UsersGetCurrentAccountResponse());
        mockDropboxService.Setup(m => m.BookmarkUrlAsync(It.IsAny<string>())).ReturnsAsync(1);
        mockDropboxService.Setup(m => m.AuthorizeUrl).Returns("someUrl");
        
        Mock<IUrlHelper> mockUrlHelper = new();
        mockUrlHelper.Setup(m => m.Action(It.IsAny<UrlActionContext>())).Returns("someUrl");

        var controller = new DocumentController(mockLogger.Object, mockDropboxService.Object)
        {
            Url = mockUrlHelper.Object
        };

        var result = await controller.IndexAsync();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(RedirectResult));
    }
}