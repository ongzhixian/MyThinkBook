using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Domain;
using System.Data.Common;

namespace MyThinkBook.Web.Data.Tests;

[TestClass()]
public class AppStateItemRepositoryTests
{
    private readonly DbConnection dbConnection;
    private readonly DbContextOptions<MyThinkBookDbContext> contextOptions;
    private readonly Mock<ILogger<AppStateItemRepository>> mockLogger = new();

    public AppStateItemRepositoryTests()
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
        var viewCommand = context.Database.GetDbConnection().CreateCommand();
        viewCommand.CommandText = @"
CREATE VIEW AllResources AS
SELECT Url
FROM Blogs;";
        viewCommand.ExecuteNonQuery();

        context.AddRange(
            new AppStateItem { Key = "item1Key", Value = "item1Value" },
            new AppStateItem { Key = "item2Key", Value = "item2Value" });

        context.SaveChanges();
        
    }

    
    [TestMethod()]
    public void AppStateItemRepositoryTest()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);

        var repository = new AppStateItemRepository(mockLogger.Object, dbContext);

        Assert.IsNotNull(repository);
        Assert.IsInstanceOfType(repository, typeof(AppStateItemRepository));
    }

    [TestMethod()]
    public void KeyContainsTest()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);
        var repository = new AppStateItemRepository(mockLogger.Object, dbContext);

        IQueryable<AppStateItem> result = repository.KeyContains("item1");

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Count());
    }

    [TestMethod()]
    public async Task KeyEqualsAsyncTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);
        var repository = new AppStateItemRepository(mockLogger.Object, dbContext);

        var item = await repository.KeyEqualsAsync("item1Key");

        Assert.IsNotNull(item);
    }

    [TestMethod()]
    public async Task AddTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);
        var repository = new AppStateItemRepository(mockLogger.Object, dbContext);

        repository.Add(new AppStateItem { Key = "newItem1Key", Value = "newItem1Value" });
        await repository.SaveChangesAsync();

        Assert.AreEqual(3, dbContext.AppStateItems.Count());
    }

    [TestMethod()]
    public async Task DeleteAsyncTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);
        var repository = new AppStateItemRepository(mockLogger.Object, dbContext);

        await repository.DeleteAsync("item1Key");

        Assert.AreEqual(1, dbContext.AppStateItems.Count());
    }

    [TestMethod()]
    public async Task SaveChangesAsyncTestAsync()
    {
        using var dbContext = new MyThinkBookDbContext(contextOptions);
        var repository = new AppStateItemRepository(mockLogger.Object, dbContext);

        repository.Add(new AppStateItem { Key = "newItem1Key", Value = "newItem1Value" });
        await repository.SaveChangesAsync();

        Assert.AreEqual(3, dbContext.AppStateItems.Count());
    }
}