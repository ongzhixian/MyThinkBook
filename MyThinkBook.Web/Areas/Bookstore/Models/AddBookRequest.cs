namespace MyThinkBook.Web.Areas.Bookstore.Models;

public class AddBookRequest
{
    public string BookTitle { get; set; } = string.Empty;

    public string BookIsbn { get; set; } = string.Empty;

    public string BookAuthors { get; set; } = string.Empty;

    public string BookPublishers { get; set; } = string.Empty;

    public string BookFormat { get; set; } = string.Empty;

    public string BookTags { get; set; } = string.Empty;

    public override string ToString()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.AppendLine($"Title: {BookTitle}");
        sb.AppendLine($"Isbn: {BookIsbn}");
        sb.AppendLine($"Authors: {BookAuthors}");
        sb.AppendLine($"Publishers: {BookPublishers}");
        sb.AppendLine($"BookFormat: {BookFormat}");
        sb.AppendLine($"Tags: {BookTags}");
        return sb.ToString();
    }
}
