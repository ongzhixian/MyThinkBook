namespace MyThinkBook.Web.Domain;

public record Instrument
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
}

public record Position
{
    public int Id { get; set; }

    public decimal Quantity { get; set; }

    public decimal Price { get; set; }

    public decimal Amount { get; set; }

    public int PortfolioId { get; set; }

    public int InstrumentId { get; set; }

    public Instrument Instrument { get; set; } = new();
}

public record Portfolio
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Position> Positions { get; set; } = new List<Position>();
}