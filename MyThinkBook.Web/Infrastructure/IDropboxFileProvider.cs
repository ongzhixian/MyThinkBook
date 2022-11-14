using Microsoft.Extensions.FileProviders;

namespace MyThinkBook.Web.Infrastructure;

public interface IDropboxFileProvider : IFileProvider
{
    Task TestAsync();
}