using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IInstrumentRepository
{
    Task<int> SaveChangesAsync();

    Task<int> AddInstrumentsAsync(IEnumerable<Instrument> instruments);

    Task<int> UpsertInstrumentsAsync(IEnumerable<Instrument> instruments);
}

public class InstrumentRepository : IInstrumentRepository
{
    private readonly ILogger<InstrumentRepository> logger;
    private readonly InvestmentDbContext dbContext;

    public InstrumentRepository(ILogger<InstrumentRepository> logger, InvestmentDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }

    public async Task<int> AddInstrumentsAsync(IEnumerable<Instrument> instruments)
    {
        try
        {
            await dbContext.Instruments.AddRangeAsync(instruments);

            return await this.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> UpsertInstrumentsAsync(IEnumerable<Instrument> instruments)
    {
        try
        {
            foreach (var instrument in instruments)
            {
                var storedInstrument = dbContext.Instruments.Where(r => r.Code == instrument.Code).FirstOrDefault();
                if (storedInstrument == null)
                {
                    await dbContext.Instruments.AddAsync(instrument);
                }
                else
                {
                    storedInstrument.Name = instrument.Name;
                    storedInstrument.Isin = instrument.Isin;
                    dbContext.Instruments.Update(storedInstrument);
                }
            }

            return await this.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
}