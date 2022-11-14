namespace MyThinkBook.Web.Extensions.Tests
{
    [TestClass()]
    public class StringEnumerableExtensionsTests
    {
        [TestMethod()]
        public void BatchCountTest()
        {
            IEnumerable<string> testObject = new List<string> { "str1", "str2", "str3", "str4", "str5", "str6", "str7", "str8" };

            var batchCount = testObject.BatchCount(3);

            Assert.AreEqual(3, batchCount);
        }
    }
}