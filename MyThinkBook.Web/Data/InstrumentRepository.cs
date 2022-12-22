using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain;

namespace MyThinkBook.Web.Data;

public interface IInstrumentRepository
{
    Task<int> SaveChangesAsync();

    Task<int> AddInstrumentsAsync(IEnumerable<Instrument> instruments);

    Task<int> UpsertInstrumentsAsync(IEnumerable<Instrument> instruments);

    Task BulkInsertIfNotExistsAsync(IEnumerable<Instrument> instruments);
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

    public async Task BulkInsertIfNotExistsAsync(IEnumerable<Instrument> instruments)
    {
        using (var dbConnection = dbContext.Database.GetDbConnection())
        {
            var cmd = dbConnection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = @"
INSERT INTO instrument (name, code, isin) 
SELECT @name, @code, @isin
WHERE NOT EXISTS(SELECT 1 FROM instrument WHERE code = @code);
";
            cmd.Parameters.Add(new Microsoft.Data.Sqlite.SqliteParameter("@name", Microsoft.Data.Sqlite.SqliteType.Text));
            cmd.Parameters.Add(new Microsoft.Data.Sqlite.SqliteParameter("@code", Microsoft.Data.Sqlite.SqliteType.Text));
            cmd.Parameters.Add(new Microsoft.Data.Sqlite.SqliteParameter("@isin", Microsoft.Data.Sqlite.SqliteType.Text));

            await dbConnection.OpenAsync();
            await cmd.PrepareAsync();

            foreach (var instrument in instruments)
            {
                cmd.Parameters["@name"].Value = instrument.Name;
                cmd.Parameters["@code"].Value = instrument.Code;
                cmd.Parameters["@isin"].Value = instrument.Isin;
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}