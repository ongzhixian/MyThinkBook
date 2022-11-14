namespace MyThinkBook.Web.Extensions.Tests;

[TestClass()]
public class StringArrayExtensionsTests
{
    [TestMethod()]
    public void BatchCountTest()
    {
        string[] testObject = new string[] { "str1", "str2","str3","str4","str5","str6","str7","str8" };

        var batchCount = testObject.BatchCount(3);

        Assert.AreEqual(3, batchCount);
    }
}