namespace MyThinkBook.Web.Models;

public interface IPageInfo
{
    byte Page { get; set; }

    byte PageSize { get; set; }
}

public record PageInfo
{
    public byte Page { get; set; } = 1;

    public byte PageSize { get; set; } = 12;
}