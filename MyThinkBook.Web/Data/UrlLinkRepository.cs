using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IUrlLinkRepository
{
    Task<int> SaveChangesAsync();

    void Add(UrlLink item);

    Task<int> UpsertAsync(UrlLink item);
}

public class UrlLinkRepository : IUrlLinkRepository
{
    private readonly ILogger<UrlLinkRepository> logger;
    private readonly MyThinkBookDbContext dbContext;

    public UrlLinkRepository(ILogger<UrlLinkRepository> logger, MyThinkBookDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public void Add(UrlLink item)
    {
        dbContext.UrlLinks.Add(item);
    }
    public async Task<int> UpsertAsync(UrlLink item)
    {
        var record = await dbContext.UrlLinks.Where(r => r.UrlHash == item.UrlHash).FirstOrDefaultAsync();

        if (record == null)
        {
            await dbContext.UrlLinks.AddAsync(item);
        }
        else
        {
            record.Count += item.Count;
            record.UpdateDateTime = DateTime.UtcNow;
        }

        return await SaveChangesAsync();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}