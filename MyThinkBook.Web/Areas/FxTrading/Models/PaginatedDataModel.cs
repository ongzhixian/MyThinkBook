using System.Collections.Immutable;

namespace MyThinkBook.Web.Areas.FxTrading.Models;

public record PaginatedDataModel<T> where T : class
{
    public int CurrentPage { get; set; }

    public int PageSize { get; set; }

    public int TotalRecordCount { get; set; }

    public int TotalPageCount { get; set; }

    public int RecordStart { get; set; }

    public int RecordEnd { get; set; }

    public ImmutableList<T>? Data { get; set; }

}
