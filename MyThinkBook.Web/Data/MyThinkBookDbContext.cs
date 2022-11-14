using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Domain.FxTrading;
using System.Diagnostics.CodeAnalysis;

namespace MyThinkBook.Web.Data;

[ExcludeFromCodeCoverage(Justification = "Entity Framework Core")]
public class MyThinkBookDbContext : DbContext
{
    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<TradeInstrument> TradeInstruments { get; set; }

    public virtual DbSet<AppStateItem> AppStateItems { get; set; }

    public virtual DbSet<Hyperlink> Hyperlinks { get; set; }

    public virtual DbSet<UrlLink> UrlLinks { get; set; }

    public MyThinkBookDbContext()
    {
        Console.WriteLine("MyThinkBookDbContext constructor with no parameters");
    }

    public MyThinkBookDbContext(DbContextOptions<MyThinkBookDbContext> options) : base(options)
    {
        Console.WriteLine("MyThinkBookDbContext constructor with options");
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    Console.WriteLine("MyThinkBookDbContext OnConfiguring");
    //    //builder.Services.AddDbContext<MyThinkBookDbContext>(options =>
    //    //options.UseSqlite(builder.Configuration.GetConnectionString("MyThinkBookDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'MyThinkBookDbContextSqlite' not found.")));
    //}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        Console.WriteLine("MyThinkBookDbContext OnConfiguring");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}