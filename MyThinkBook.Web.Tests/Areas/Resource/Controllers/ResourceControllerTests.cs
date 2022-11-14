using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace MyThinkBook.Web.Areas.Resource.Controllers.Tests
{
    [TestClass()]
    public class ResourceControllerTests
    {
        Mock<ILogger<ResourceController>> mockLogger = new();

        [TestMethod()]
        public void ResourceControllerTest()
        {
            var controller = new ResourceController(mockLogger.Object);

            Assert.IsNotNull(controller);
        }

        [TestMethod()]
        public void IndexTest()
        {
            var controller = new ResourceController(mockLogger.Object);

            var result = controller.Index("some");

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}