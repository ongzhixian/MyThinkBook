namespace MyThinkBook.Web.Domain;

public record Book
{
    public string Title { get; set; } = string.Empty;

    public List<Name> Authors { get; set; } = new List<Name>();

    public string Publisher { get; set; } = string.Empty;

    public DateTime? PublicationDate { get; set; } = null;

    public string InternationalStandardBookNumber { get; set; } = string.Empty;

    public string Format { get; set; } = string.Empty;

    public List<string> Tags { get; set; } = new List<string>();

}


public record Name
{
    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;
}

public record Tag
{
    public string Text { get; set; } = string.Empty;
}


//Publisher: The company or organization that published the book.
//Date of publication: The year in which the book was published.
//ISBN: The International Standard Book Number, a unique identifier for the book.
//Genre: The category or type of book, such as fiction, non-fiction, mystery, romance, etc.
//Format: The physical format of the book, such as hardcover, paperback, or electronic.
//Number of pages: The total number of pages in the book.
