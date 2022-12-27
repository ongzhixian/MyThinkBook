using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyThinkBook.Web.Domain;

public enum HyperlinkStatus : byte
{
    Unprocessed = 0,
    Processed = 1,
    Error = 255
}

[Table("hyperlink")]
public class Hyperlink
{
    [Key]
    public int Id { get; set; }

    public string Url { get; set; } = string.Empty;

    public HyperlinkStatus Status { get; set; } = HyperlinkStatus.Unprocessed;
}

public class UnprocessedHyperlink
{
    public string Url { get; set; } = string.Empty;

    public int Count { get; set; }

    public List<int> IdList { get; set; } = new List<int>();
}


[Table("url_link")]
public class UrlLink
{
    [Key]
    public string UrlHash { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public string UrlDomain { get; set; } = string.Empty;

    public int Count { get; set; }

    public int Status { get; set; }

    public DateTime CreateDateTime { get; set; } = DateTime.UtcNow;

    public DateTime UpdateDateTime { get; set; } = DateTime.UtcNow;
}
