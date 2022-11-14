namespace MyThinkBook.Web.Extensions.Tests;

[TestClass()]
public class UriExtensionsTests
{
    [TestMethod()]
    public void AsSHA256Base64Test()
    {
        Uri testObject = new Uri("https://localhost");
        
        string result = testObject.AsSHA256Base64();

        Assert.IsNotNull(result);
        Assert.AreEqual("8rmc4FuUWZVJxw2756iRsnjnw8rK0CM0+kRoL8o2x0A=", result);
    }
}