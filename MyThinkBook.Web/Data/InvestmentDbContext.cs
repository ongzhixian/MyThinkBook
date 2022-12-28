using Bogus;
using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;
using System.Diagnostics.CodeAnalysis;

namespace MyThinkBook.Web.Data;

[ExcludeFromCodeCoverage(Justification = "Entity Framework Core")]
public class InvestmentDbContext : DbContext
{
    public virtual DbSet<Portfolio> Portfolios { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Instrument> Instruments { get; set; }

    public InvestmentDbContext()
    {
    }

    public InvestmentDbContext(DbContextOptions<InvestmentDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Portfolio>(e =>
        {
            e.ToTable("portfolio");
            e.Property(o => o.Id).HasColumnName("id");
            e.Property(o => o.Name).HasColumnName("name");
            e.HasKey(o => o.Id).HasName("portfolio_pk");

            e.HasMany(m => m.Positions).WithOne().HasConstraintName("portfolio__position_fk");
        });

        modelBuilder.Entity<Position>(e =>
        {
            e.ToTable("position");
            e.Property(o => o.Id).HasColumnName("id");

            e.Property(o => o.TradeDate).HasColumnName("trade_date");
            e.Property(o => o.Quantity).HasColumnName("quantity");
            e.Property(o => o.Price).HasColumnName("price");
            e.Ignore(o => o.Amount); // e.Property(o => o.Amount).UsePropertyAccessMode(PropertyAccessMode.Property);
            e.Property(o => o.PortfolioId).HasColumnName("portfolio_id");
            e.Property(o => o.InstrumentId).HasColumnName("instrument_id");

            e.HasKey(e => e.Id).HasName("position_pk");

            //e.HasIndex(p => new { p.PortfolioId, p.InstrumentId }).IsUnique().HasDatabaseName("IX_position_portfolio_id_instrument_idXXX");
            //e.HasOne(m => m.Instrument).WithOne().HasConstraintName("position__instrument_fk");
            e.HasOne(m => m.Instrument).WithMany().HasConstraintName("position__instrument_fk");
        });

        modelBuilder.Entity<Instrument>(e =>
        {
            e.ToTable("instrument");
            e.Property(o => o.Id).HasColumnName("id");

            e.Property(o => o.Name).HasColumnName("name");
            e.Property(o => o.Isin).HasColumnName("isin");
            e.Property(o => o.Code).HasColumnName("code");

            e.HasKey(e => e.Id).HasName("instrument_pk");
            e.HasIndex(e => e.Code).IsUnique();
        });

        Randomizer.Seed = new Random(2096352011);

        int stockId = 1;
        var fakeInstrumentGenerator = new Faker<Instrument>()
            .RuleFor(m => m.Id, f => stockId)
            .RuleFor(m => m.Name, f => $"Stock {stockId++}")
            .RuleFor(m => m.Isin, f => f.Finance.Random.AlphaNumeric(9))
            .RuleFor(m => m.Code, f => f.Finance.Random.AlphaNumeric(4));
        var instruments = fakeInstrumentGenerator.Generate(30);

        int positionId = 1;
        var fakePositionGenerator = new Faker<Position>()
            .RuleFor(m => m.Id, f => positionId++)
            .RuleFor(m => m.TradeDate, f => f.Date.Past(4))
            .RuleFor(m => m.Quantity, f => f.Random.Number(100, 9999))
            .RuleFor(m => m.Price, f => decimal.Parse(f.Commerce.Price(1M, 399.99M)))
            .FinishWith((f, position) =>
            {
                var randomInstrument = f.PickRandom(instruments);
                position.InstrumentId = randomInstrument.Id;
            });

        int portfolioId = 1;
        var fakePortfolioGenerator = new Faker<Portfolio>()
            .RuleFor(m => m.Id, f => portfolioId)
            .RuleFor(m => m.Name, f => $"Portfolio {portfolioId}")
            //.RuleFor(m => m.Positions, f => fakePositionGenerator.Generate(f.Random.Number(1, 5)).ToList())
            .FinishWith((f, portfolio) =>
            {
                //foreach (var position in portfolio.Positions)
                //{
                //    position.PortfolioId = portfolioId;
                //}
                portfolioId++;
            });

        List<Position> positions= new();
        var faker = new Faker();
        List<Portfolio> portfolios = fakePortfolioGenerator.Generate(48);
        portfolios.ForEach(portfolio =>
        {
            var portfolioPositions = fakePositionGenerator.Generate(faker.Random.Number(1, 40)).ToList();

            foreach (var position in portfolioPositions)
            {
                position.PortfolioId = portfolio.Id;
                //Console.WriteLine(position);
            }

            positions.AddRange(portfolioPositions);
        });

        modelBuilder.Entity<Instrument>().HasData(instruments);
        modelBuilder.Entity<Portfolio>().HasData(portfolios);
        modelBuilder.Entity<Position>().HasData(positions);

        //modelBuilder.Entity<Blog>(entity => { entity.Property(e => e.Url).IsRequired(); });

        //// BlogSeed
        //modelBuilder.Entity<Blog>().HasData(new Blog { BlogId = 1, Url = "http://sample.com" });

        //modelBuilder.Entity<Post>(
        //    entity =>
        //    {
        //        entity.HasOne(d => d.Blog)
        //            .WithMany(p => p.Posts)
        //            .HasForeignKey("BlogId");
        //    });

        //// PostSeed
        //modelBuilder.Entity<Post>().HasData(
        //    new Post { BlogId = 1, PostId = 1, Title = "First post", Content = "Test 1" });

        //// AnonymousPostSeed
        //modelBuilder.Entity<Post>().HasData(
        //    new { BlogId = 1, PostId = 2, Title = "Second post", Content = "Test 2" });

        //// OwnedTypeSeed
        //modelBuilder.Entity<Post>().OwnsOne(p => p.AuthorName).HasData(
        //    new { PostId = 1, First = "Andriy", Last = "Svyryd" },
        //    new { PostId = 2, First = "Diego", Last = "Vega" });
    }
}