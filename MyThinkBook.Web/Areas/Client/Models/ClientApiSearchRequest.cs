using MyThinkBook.Web.Models;

namespace MyThinkBook.Web.Areas.Client.Models;

public record ClientApiSearchRequest : PageInfo
{
    public string SearchTerm { get; set; } = string.Empty;
}