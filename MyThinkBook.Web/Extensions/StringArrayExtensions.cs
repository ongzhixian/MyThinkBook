namespace MyThinkBook.Web.Extensions;

public static class StringArrayExtensions
{
    /// <summary>
    /// Count number of batches that can be grouped for a given a batch size
    /// </summary>
    /// <param name="stringArray"></param>
    /// <param name="batchSize"></param>
    /// <returns></returns>
    public static int BatchCount(this string[] stringArray, int batchSize)
    {
        return (stringArray.Length / batchSize) + (((stringArray.Length % batchSize) > 0) ? 1 : 0);
    }
}

public static class StringEnumerableExtensions
{
    public static int BatchCount(this IEnumerable<string> stringEnumerable, int batchSize)
    {
        var stringCount = stringEnumerable.Count();

        return (stringCount / batchSize) + (((stringCount % batchSize) > 0) ? 1 : 0);
    }
}