using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IHyperlinkRepository
{
    Task<int> SaveChangesAsync();
    
    void Add(Hyperlink item);

    Task<int> AddAsync(IEnumerable<Hyperlink> hyperlinks);

    Task<List<UnprocessedHyperlink>> GetUnprocessedAsync();

    Task<int> UpdateUnprocessedHyperlinkAsync(UnprocessedHyperlink unprocessedHyperlink
        , HyperlinkStatus hyperlinkStatus = HyperlinkStatus.Processed);
}

public class HyperlinkRepository : IHyperlinkRepository
{
    private readonly ILogger<HyperlinkRepository> logger;
    private readonly MyThinkBookDbContext dbContext;

    public HyperlinkRepository(ILogger<HyperlinkRepository> logger, MyThinkBookDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public void Add(Hyperlink item)
    {
        Console.WriteLine($"Tracking behaviour {dbContext.ChangeTracker.QueryTrackingBehavior}");
        dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        dbContext.Hyperlinks.Add(item);
    }

    public async Task<int> AddAsync(IEnumerable<Hyperlink> hyperlinks)
    {
        dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        await dbContext.Hyperlinks.AddRangeAsync(hyperlinks);

        return await dbContext.SaveChangesAsync();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }

    public async Task<List<UnprocessedHyperlink>> GetUnprocessedAsync()
    {
        List<UnprocessedHyperlink> result = await dbContext.Hyperlinks
            .Where(r => r.Status == 0)
            .GroupBy(r => r.Url)
            .Select(group => new UnprocessedHyperlink
            {
                Url = group.Key,
                Count = group.Count(),
                IdList = group.Select(r => r.Id).ToList(),
            })
            .OrderBy(r => r.Url)
            .ToListAsync();

        return result;
    }

    public async Task<int> UpdateUnprocessedHyperlinkAsync(UnprocessedHyperlink unprocessedHyperlink
        , HyperlinkStatus hyperlinkStatus = HyperlinkStatus.Processed)
    {
        var hyperlinks = await dbContext.Hyperlinks
            .Where(r => unprocessedHyperlink.IdList.Contains(r.Id))
            .ToListAsync();

        hyperlinks.ForEach(hyperlink =>
        {
            hyperlink.Status = hyperlinkStatus;
        });

        return await SaveChangesAsync();
    }

    //public void BulkAdd(Hyperlink item)
    //{
    //    Console.WriteLine($"Tracking behaviour {dbContext.ChangeTracker.QueryTrackingBehavior}");
    //    dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    //    //dbContext.Configuration.AutoDetectChangesEnabled = false;
    //    dbContext.Hyperlinks.Add(item);
    //}
}