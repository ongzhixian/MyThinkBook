using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Controllers;

namespace MyThinkBook.Web.Tests.Controllers;

[TestClass()]
public class HttpStatusControllerTests
{
    Mock<ILogger<HttpStatusController>> mockLogger = new();

    [TestMethod()]
    public void HttpStatusControllerTest()
    {
        var controller = new HttpStatusController(mockLogger.Object);

        Assert.IsNotNull(controller);
        Assert.IsInstanceOfType(controller, typeof(HttpStatusController));
    }

    [TestMethod()]
    public void IndexTest()
    {
        var controller = new HttpStatusController(mockLogger.Object);

        var result = controller.Index(404);
        
        Assert.IsNotNull(result);
    }
}