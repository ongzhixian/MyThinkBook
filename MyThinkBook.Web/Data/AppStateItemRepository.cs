using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IAppStateItemRepository
{
    IQueryable<AppStateItem> KeyContains(string key);

    Task<AppStateItem?> KeyEqualsAsync(string key);
    
    Task<int> SaveChangesAsync();

    Task<int> DeleteAsync(string key);

    void Add(AppStateItem item);
}

public class AppStateItemRepository : IAppStateItemRepository
{
    private readonly ILogger<AppStateItemRepository> logger;
    private readonly MyThinkBookDbContext dbContext;

    public AppStateItemRepository(ILogger<AppStateItemRepository> logger, MyThinkBookDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public IQueryable<AppStateItem> KeyContains(string key)
    {
        return dbContext.AppStateItems.Where(x => x.Key.Contains(key));
    }

    public async Task<AppStateItem?> KeyEqualsAsync(string key)
    {
        return await dbContext.AppStateItems.Where(r => r.Key == key).FirstOrDefaultAsync();
    }

    public void Add(AppStateItem item)
    {
        dbContext.AppStateItems.Add(item);
    }

    public async Task<int> DeleteAsync(string key)
    {
        return await dbContext.AppStateItems.Where(r => r.Key == key).ExecuteDeleteAsync();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}