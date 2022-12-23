using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Models;
using System.Collections.Immutable;
using System.Drawing.Printing;

namespace MyThinkBook.Web.Data;

public interface IPortfolioRepository
{
    Task<int> SaveChangesAsync();

    Task<DataPageModel<Portfolio>> GetPaginatedPortfoliosAsync(byte page = 1, byte pageSize = 20);
}

public class PortfolioRepository : IPortfolioRepository
{
    private readonly ILogger<PortfolioRepository> logger;
    private readonly InvestmentDbContext dbContext;

    public PortfolioRepository(ILogger<PortfolioRepository> logger, InvestmentDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public async Task<DataPageModel<Portfolio>> GetPaginatedPortfoliosAsync(byte page = 1, byte pageSize = 20)
    {
        int recordsToSkip = (page - 1) * pageSize;

        var records = (await dbContext.Portfolios.Include(m => m.Positions)
            .OrderBy(p => p.Name)
            .Skip(recordsToSkip)
            .Take(pageSize)
            .ToListAsync()).ToImmutableList();

        int totalRecordCount = dbContext.Portfolios.Count();

        int recordStart = recordsToSkip + 1;

        int recordEnd = recordsToSkip + records.Count;

        return new DataPageModel<Portfolio>
        {
            CurrentPage = page,
            PageSize = pageSize,
            TotalRecordCount = totalRecordCount,
            TotalPageCount = (totalRecordCount / pageSize) + ((totalRecordCount % pageSize) > 0 ? 1 : 0),
            Data = records,
            RecordStart = recordStart,
            RecordEnd = recordEnd
        };
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}