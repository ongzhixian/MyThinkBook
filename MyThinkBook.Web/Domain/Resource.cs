namespace MyThinkBook.Web.Domain;

public record Resource
{
    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public ResourceLocation Location { get; set; } = ResourceLocation.Unspecified;
}
