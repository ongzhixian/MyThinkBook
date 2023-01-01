namespace MyThinkBook.Domain.Common;

/// <summary>
/// A name is composed of a first name, last name and middle name.
/// </summary>
public interface IPersonName
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MiddleName { get; set; }
}

public record PersonName : IPersonName
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;
}