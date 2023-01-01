using Microsoft.EntityFrameworkCore;
using MyThinkBook.Domain;
using MyThinkBook.Domain.Common;
using System.Diagnostics.CodeAnalysis;

namespace MyThinkBook.Web.Data;

// Bookstore database entities

public record BookstoreBook : Book
{ 
    public int Id { get; set; }

    public new virtual ICollection<BookstoreAuthor> Authors { get; set; } = default!;

    //public new virtual ICollection<BookPublisher> Publishers { get; set; } = default!;

    //public new virtual ICollection<Tag> Tags { get; set; } = default!;
}

public record BookstoreAuthor : BookAuthor
{
    public int Id { get; set; }

    //public new ICollection<BookstoreBook> Books { get; set; } = default!;
    
}

public record BookstorePublisher : BookPublisher
{
    public int Id { get; set; }
}

public record BookstoreTag : Tag
{
    public int Id { get; set; }
}

// Bookstore DbContext

[ExcludeFromCodeCoverage(Justification = "Entity Framework Core")]
public class BookstoreDbContext : DbContext
{
    public virtual DbSet<BookstoreBook> Books { get; set; }

    public virtual DbSet<BookstoreAuthor> Authors { get; set; }

    //public virtual DbSet<BookstorePublisher> Publishers { get; set; }

    //public virtual DbSet<BookstoreTag> Tags { get; set; }

    public BookstoreDbContext()
    {
    }

    public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Ignore<Book>();
        //modelBuilder.Entity<Book>().HasNoKey();
        //modelBuilder.Ignore<BookAuthor>();
        //modelBuilder.Entity<BookAuthor>().HasNoKey();

        //modelBuilder.Ignore<BookPublisher>();
        //modelBuilder.Ignore<Tag>();

        modelBuilder.Entity<BookstoreBook>(e =>
        {
            e.ToTable("book");
            e.Property(o => o.Id).HasColumnName("id");
            e.Property(o => o.Title).HasColumnName("title");
            e.Property(o => o.InternationalStandardBookNumber).HasColumnName("isbn");
            e.Property(o => o.Format).HasColumnName("format");

            e.HasMany(m => m.Authors).WithOne()
                .HasForeignKey(m => m.Id)
                .HasConstraintName("book__author_fk");
            //e.HasMany(m => m.Publishers).WithOne().HasConstraintName("book__publisher_fk");
            //e.HasMany(m => m.Tags).WithOne().HasConstraintName("book__tag_fk");

            e.HasKey(o => o.Id).HasName("book_pk");
            //e.HasMany(m => m.Positions).WithOne().HasConstraintName("portfolio__position_fk");
        });

        modelBuilder.Entity<BookstoreAuthor>(e =>
        {
            e.ToTable("author");
            e.Property(o => o.Id).HasColumnName("id");
            e.Property(o => o.FirstName).HasColumnName("first_name");
            e.Property(o => o.LastName).HasColumnName("last_name");
            e.Property(o => o.MiddleName).HasColumnName("middle_name");

            e.HasMany(m => m.Books).WithOne()
                //.HasForeignKey(m => m.Id)
                .HasConstraintName("author__book_fk");

            e.HasKey(o => o.Id).HasName("author_pk");
        });

        //modelBuilder.Entity<BookstorePublisher>(e =>
        //{
        //    e.ToTable("publisher");
        //    e.Property(o => o.Id).HasColumnName("id");
        //    e.Property(o => o.Name).HasColumnName("name");

        //    e.HasKey(o => o.Id).HasName("publisher_pk");

        //    e.HasMany(m => m.Books).WithOne().HasConstraintName("publisher__book_fk");
        //});

        //modelBuilder.Entity<BookstoreTag>(e =>
        //{
        //    e.ToTable("tag");
        //    e.Property(o => o.Id).HasColumnName("id");
        //    e.Property(o => o.Label).HasColumnName("label");

        //    e.HasKey(o => o.Id).HasName("tag_pk");
        //});
    }
}

// Reference:
// 1. msqql pubs database 
