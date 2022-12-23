using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Models;
using System.Collections.Immutable;
using System.Drawing.Printing;

namespace MyThinkBook.Web.Data;

public interface IPositionRepository
{
    Task<int> SaveChangesAsync();

    Task<DataPageModel<Position>> GetPaginatedPositionsAsync(int id, byte page = 1, byte pageSize = 20);
}

public class PositionRepository : IPositionRepository
{
    private readonly ILogger<PositionRepository> logger;
    private readonly InvestmentDbContext dbContext;

    public PositionRepository(ILogger<PositionRepository> logger, InvestmentDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public async Task<DataPageModel<Position>> GetPaginatedPositionsAsync(int id, byte page = 1, byte pageSize = 20)
    {
        int recordsToSkip = (page - 1) * pageSize;

        var records = (await dbContext.Positions.Include(m => m.Instrument)
            .Where(r => r.PortfolioId == id)
            .OrderBy(p => p.Instrument.Name)
            .Skip(recordsToSkip)
            .Take(pageSize)
            .ToListAsync()).ToImmutableList();

        int totalRecordCount = await dbContext.Positions.Where(r => r.PortfolioId == id).CountAsync();

        int recordStart = recordsToSkip + 1;

        int recordEnd = recordsToSkip + records.Count;

        return new DataPageModel<Position>
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