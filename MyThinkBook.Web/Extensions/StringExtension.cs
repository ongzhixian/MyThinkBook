namespace MyThinkBook.Web.Extensions;

public static class StringExtensions
{
    public static double ToEpochTime(this string str)
    {
        return DateTime.Parse(str).ToUniversalTime().Subtract(DateTime.UnixEpoch).TotalMilliseconds;
    }

    public static decimal ToDecimal(this string str)
    {
        return Convert.ToDecimal(str);
    }
}
