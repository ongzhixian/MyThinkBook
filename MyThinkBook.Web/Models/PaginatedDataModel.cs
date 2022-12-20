using System.Collections.Immutable;

namespace MyThinkBook.Web.Models;

public interface IPaginationData
{
    int CurrentPage { get; set; }

    int PageSize { get; set; }

    int TotalRecordCount { get; set; }

    int TotalPageCount { get; set; }

    int RecordStart { get; set; }

    int RecordEnd { get; set; }
}

public record PaginatedDataModel<T> : IPaginationData where T : class
{
    public int CurrentPage { get; set; }

    public int PageSize { get; set; }

    public int TotalRecordCount { get; set; }

    public int TotalPageCount { get; set; }

    public int RecordStart { get; set; }

    public int RecordEnd { get; set; }

    public ImmutableList<T>? Data { get; set; }

}
