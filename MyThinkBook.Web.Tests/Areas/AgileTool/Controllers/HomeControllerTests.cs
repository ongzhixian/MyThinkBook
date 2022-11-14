using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Areas.AgileTool.Controllers;

namespace MyThinkBook.Web.Tests.Areas.AgileTool.Controllers
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}