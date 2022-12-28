namespace MyThinkBook.Domain.Wms;

// Setup

// Inventory

// As an inventory owner, I want to know how many items do I have.

public record UnitOfMeasure
{
    public string Name { get; set; } = string.Empty;

    public string Abbreviation { get; set; } = string.Empty;

    public static readonly UnitOfMeasure Piece = new()
    {
        Name = "Piece",
        Abbreviation = "PC"
    };
}

public record UnitQuantity
{
    public decimal Quantity { get; set; }

    public UnitOfMeasure Unit { get; set; } = UnitOfMeasure.Piece;
}

public record Item
{
    // Who / What / Where / When / How

    public string Name { get; set; } = string.Empty;

    
}

public record StoredItem
{
    // Who / What / Where / When / How

    public string StoredBy { get; set; } = string.Empty;

    public Item Item { get; set; }

    public string Location { get; set; }

    public DateTime StoredOn { get; set; }

    public UnitQuantity Quantity { get; set; }
}

public class InventoryPlaceHolder
{
    // Who / What / Where / When / How

    public IEnumerable<StoredItem> StoredItems { get; set; } = new List<StoredItem>();
}

// Receive
// Send
// Setup

public record Client
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;
}
