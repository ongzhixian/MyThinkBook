namespace MyThinkBook.Web.Models;

public record PageInfo
{
    public byte Page { get; set; } = 1;

    public byte PageSize { get; set; } = 12;
}