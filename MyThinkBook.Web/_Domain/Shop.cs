namespace MyThinkBook.Web.Domain;

public record Shop
{
    public string Name { get; set; } = string.Empty;

    public List<Name> Authors { get; set; } = new List<Name>();

    public string Publisher { get; set; } = string.Empty;

    public DateTime? PublicationDate { get; set; } = null;

    public string InternationalStandardBookNumber { get; set; } = string.Empty;

    public string Format { get; set; } = string.Empty;

    public List<string> Tags { get; set; } = new List<string>();

}

public record Address
{
    public string Line1 { get; set; } = string.Empty;

    public string Line2 { get; set; } = string.Empty;

    public string Line3 { get; set; } = string.Empty;

    public string Line4 { get; set; } = string.Empty;

    public string Building { get; set; } = string.Empty;

    public string Street { get; set; } = string.Empty;

    public string Unit { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

}

public enum ContactType
{
    Telephone,
    Mobile,
    Fax
}

public record Contact
{
    public ContactType Type { get; set; }

    public string Number { get; set; } = string.Empty;
}