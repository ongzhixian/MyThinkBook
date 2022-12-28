using System.Collections.Immutable;

namespace MyThinkBook.Web.Models;

public interface IPageMetaData
{
    int CurrentPage { get; set; }

    int PageSize { get; set; }

    int TotalRecordCount { get; set; }

    int TotalPageCount { get; set; }

    int RecordStart { get; set; }

    int RecordEnd { get; set; }
}

public record DataPageModel<T> : IPageMetaData where T : class
{
    public int CurrentPage { get; set; }

    public int PageSize { get; set; }

    public int TotalRecordCount { get; set; }

    public int TotalPageCount { get; set; }

    public int RecordStart { get; set; }

    public int RecordEnd { get; set; }

    public IEnumerable<T> Data { get; set; } = Enumerable.Empty<T>();

    public DataPageModel()
    {
    }

    public DataPageModel(IEnumerable<T> dataList, byte page = 1, byte pageSize = 10)
    {
        PageSize = pageSize;

        int recordsToSkip = (page - 1) * pageSize;

        Data = dataList
            .Skip(recordsToSkip)
            .Take(pageSize);

        TotalRecordCount = dataList.Count();

        TotalPageCount = (TotalRecordCount / pageSize) + ((TotalRecordCount % pageSize) > 0 ? 1 : 0);

        RecordStart = recordsToSkip + (TotalRecordCount > 0 ? 1 : 0);

        RecordEnd = recordsToSkip + Data.Count();

        CurrentPage = TotalPageCount == 0 ? 0 : page;
    }
}