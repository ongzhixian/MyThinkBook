using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.Api.Tests;

[TestClass()]
public class DropboxControllerTests
{
    private readonly Mock<ILogger<DropboxController>> mockLogger = new();
    private readonly Mock<IDropboxService> mockDropboxService = new();

    [TestMethod()]
    public void DropboxControllerTest()
    {
        var controller = new DropboxController(mockLogger.Object, mockDropboxService.Object);

        Assert.IsNotNull(controller);
    }

    [TestMethod()]
    public async Task AuthorizeAsyncTestAsync_WhenNoBookmarkUrlExists()
    {
        const string authorizationCode = "someCode";
        var controller = new DropboxController(mockLogger.Object, mockDropboxService.Object);
        mockDropboxService.Setup(m => m.ExchangeCodeForBearerTokenAsync(authorizationCode)).Returns(Task.CompletedTask);
        mockDropboxService.Setup(m => m.GetBookmarkUrlAsync()).ReturnsAsync(string.Empty);

        var result = await controller.AuthorizeAsync(authorizationCode);

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(Microsoft.AspNetCore.Mvc.RedirectToActionResult));
    }

    [TestMethod()]
    public async Task AuthorizeAsyncTestAsync_WhenBookmarkUrlExists()
    {
        const string authorizationCode = "someCode";
        var controller = new DropboxController(mockLogger.Object, mockDropboxService.Object);
        mockDropboxService.Setup(m => m.ExchangeCodeForBearerTokenAsync(authorizationCode)).Returns(Task.CompletedTask);
        mockDropboxService.Setup(m => m.GetBookmarkUrlAsync()).ReturnsAsync("someBookmarkUrl");
        mockDropboxService.Setup(m => m.ClearBookmarkUrlAsync()).ReturnsAsync(1);

        var result = await controller.AuthorizeAsync(authorizationCode);

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(Microsoft.AspNetCore.Mvc.RedirectResult));
    }
}