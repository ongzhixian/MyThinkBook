namespace MyThinkBook.Web.Api.Tests;

[TestClass()]
public class ApplicationControllerTests
{
    [TestMethod()]
    public void GetTest()
    {
        var controller = new ApplicationController();

        var result = controller.Get();

        Assert.IsNotNull(result);
        Assert.IsTrue(result.Contains("value1"));
        Assert.IsTrue(result.Contains("value2"));
    }
}