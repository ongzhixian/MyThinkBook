using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IPortfolioRepository
{
    Task<int> SaveChangesAsync();

    Task<IEnumerable<Portfolio>> GetPortfoliosAsync(int page = 1, int pageSize = 25);
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

    public async Task<IEnumerable<Portfolio>> GetPortfoliosAsync(int page = 1, int pageSize = 25)
    {
        return await dbContext.Portfolios.Include(m => m.Positions)
            .OrderBy(p => p.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}