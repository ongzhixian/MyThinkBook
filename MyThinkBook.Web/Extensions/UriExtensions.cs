using NuGet.Common;
using System.Security.Cryptography;
using System.Text;

namespace MyThinkBook.Web.Extensions;

public static class UriExtensions
{
    public static string AsSHA256Base64(this Uri uri)
    {
        using SHA256 hashAlgorithm = SHA256.Create();

        using MemoryStream ms = new(Encoding.UTF8.GetBytes(uri.ToString()));

        return hashAlgorithm.ComputeHashAsBase64(ms);
    }
}
