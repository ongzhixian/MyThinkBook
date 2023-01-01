namespace MyThinkBook.Domain.Common;

/// <summary>
/// A tag has a label
/// </summary>
public record Tag
{
    public string Label { get; set; } = string.Empty;
}