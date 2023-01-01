using MyThinkBook.Domain.Common;

namespace MyThinkBook.Domain;

// Currently we are using Book in 2 places.
// 1. In Book-store context
// 2. In Book-library context
// Let's redefine what is a book.


public interface IBook
{
    string Title { get; set; }
    
    string InternationalStandardBookNumber { get; set; }
    
    string Format { get; set; }

    ICollection<BookAuthor> Authors { get; set; }

    //ICollection<BookPublisher> Publishers { get; set; }
    
    //ICollection<Tag> Tags { get; set; }
}

/// <summary>
/// A book has title, and format.
/// </summary>
public record Book : IBook
{
    public string Title { get; set; } = string.Empty;

    public string InternationalStandardBookNumber { get; set; } = string.Empty;

    public string Format { get; set; } = string.Empty;

    // Do we care about publication dates?

    public virtual ICollection<BookAuthor> Authors { get; set; } = default!;

    //public virtual ICollection<BookPublisher> Publishers { get; set; } = default!;

    //public virtual ICollection<Tag> Tags { get; set; } = default!;
}


/// <summary>
/// A book author has name, and collection of books written or co-authored.
/// </summary>
public record BookAuthor : IPersonName
{
    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;

    public virtual ICollection<Book> Books { get; set; } = default!;
}


/// <summary>
/// A book publisher has name and collection of books published.
/// </summary>
public record BookPublisher
{
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Book> Books { get; set; } = default!;
}