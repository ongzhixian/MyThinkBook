using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Domain;
using System.Data.Common;

namespace MyThinkBook.Web.Data.Tests;

[TestClass()]
public class HyperlinkRepositoryTests
{
    private readonly DbConnection dbConnection;
    private readonly DbContextOptions<MyThinkBookDbContext> contextOptions;
    private readonly Mock<ILogger<HyperlinkRepository>> mockLogger = new();

    public HyperlinkRepositoryTests()
    {
        dbConnection = new SqliteConnection("Filename=:memory:");

        // These options will be used by the context instances in this test suite, including the connection opened above.
        contextOptions = new DbContextOptionsBuilder<MyThinkBookDbContext>()
            .UseSqlite(dbConnection)
            .Options;

        dbConnection.Open();

        // Create the schema and seed some data
        using var context = new MyThinkBookDbContext(contextOptions);

        context.Database.EnsureCreated();

        SeedTestData(context);
    }
    private static void SeedTestData(MyThinkBookDbContext context)
    {
        //context.AddRange(
        //    new AppStateItem { Key = "item1Key", Value = "item1Value" },
        //    new AppStateItem { Key = "item2Key", Value = "item2Value" });

        //context.SaveChanges();
    }

    [TestMethod()]
    public void HyperlinkRepositoryTest()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);

        var repository = new HyperlinkRepository(mockLogger.Object, dbContext);

        Assert.IsNotNull(repository);
        Assert.IsInstanceOfType(repository, typeof(HyperlinkRepository));
    }

    [TestMethod()]
    public async Task AddTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);

        var repository = new HyperlinkRepository(mockLogger.Object, dbContext);

        repository.Add(new Hyperlink());

        await repository.SaveChangesAsync();

        var hyperlinksCount = dbContext.Hyperlinks.Count();

        Assert.AreEqual(1, hyperlinksCount);
    }

    [TestMethod()]
    public async Task AddAsyncTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);

        var repository = new HyperlinkRepository(mockLogger.Object, dbContext);

        var addCount = await repository.AddAsync(new List<Hyperlink> {
            new Hyperlink(),
            new Hyperlink(),
            new Hyperlink()
        });

        Assert.AreEqual(3, addCount);
    }


    [TestMethod()]
    public async Task GetUnprocessedAsyncTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);

        dbContext.AddRange(
            new Hyperlink { Url = "http://localhost" },
            new Hyperlink { Url = "http://localhost" });
        dbContext.SaveChanges();

        var repository = new HyperlinkRepository(mockLogger.Object, dbContext);

        var result = await repository.GetUnprocessedAsync();

        Assert.AreEqual(1, result.Count);
    }

    [TestMethod()]
    public async Task UpdateUnprocessedHyperlinkAsyncTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);

        dbContext.AddRange(
            new Hyperlink(),
            new Hyperlink());
        dbContext.SaveChanges();

        var repository = new HyperlinkRepository(mockLogger.Object, dbContext);

        UnprocessedHyperlink unprocessedHyperlink = new UnprocessedHyperlink
        {
            Count = 1,
            Url = "some url",
            IdList = new List<int> { 1 }
        };

        var updateCount = await repository.UpdateUnprocessedHyperlinkAsync(unprocessedHyperlink);

        Assert.AreEqual(1, updateCount);
    }
}