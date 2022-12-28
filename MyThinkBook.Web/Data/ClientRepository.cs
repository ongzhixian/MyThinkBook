using Microsoft.EntityFrameworkCore;
using MyThinkBook.Domain.Wms;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Models;
using System.Collections.Immutable;
using static Dropbox.Api.Sharing.ListFileMembersIndividualResult;

namespace MyThinkBook.Web.Data;

public interface IClientRepository
{
    Task<int> SaveChangesAsync();

    Task<DataPageModel<Client>> GetPaginatedClientsAsync(byte page = 1, byte pageSize = 20);
    

    void Add(Client item);


    Task<List<Client>> NameContainsAsync(string searchTerm, byte page, byte pageSize);

    Task<List<string>> ClientNameLikeAsync(string searchTerm, byte page = 1, byte pageSize = 12);
}

public class ClientRepository : IClientRepository
{
    private readonly ILogger<ClientRepository> logger;
    private readonly WmsDbContext dbContext;

    public ClientRepository(ILogger<ClientRepository> logger, WmsDbContext dbContext)
    {
        this.logger = logger;
        this.dbContext = dbContext;
    }

    public void Add(Client item)
    {
        dbContext.Clients.Add(item);
    }

    public async Task<DataPageModel<Client>> GetPaginatedClientsAsync(byte page = 1, byte pageSize = 20)
    {
        int recordsToSkip = (page - 1) * pageSize;

        var records = (await dbContext.Clients
            .OrderBy(p => p.Name)
            .Skip(recordsToSkip)
            .Take(pageSize)
            .ToListAsync())
            .ToImmutableList();

        int totalRecordCount = dbContext.Clients.Count();

        int totalPageCount = (totalRecordCount / pageSize) + ((totalRecordCount % pageSize) > 0 ? 1 : 0);

        int recordStart = recordsToSkip + (totalRecordCount > 0 ? 1 : 0);

        int recordEnd = recordsToSkip + records.Count;

        var result = new DataPageModel<Client>
        {
            PageSize = pageSize,
            TotalRecordCount = totalRecordCount,
            TotalPageCount = totalPageCount,
            Data = records,
            RecordStart = recordStart,
            RecordEnd = recordEnd,
            CurrentPage = totalPageCount == 0 ? 0 : page,
        };

        logger.LogInformation("{methodName} {page}, {pageSize} returns {resultType} {result}", 
            nameof(GetPaginatedClientsAsync), page, pageSize, nameof(DataPageModel<Client>), result);
        return result;
    }

    public async Task<List<Client>> NameContainsAsync(string searchTerm, byte page, byte pageSize)
    {
        int recordsToSkip = (page - 1) * pageSize;

        try
        {
            var result = await dbContext.Clients
            .Where(r => EF.Functions.Like(r.Name, $"%{searchTerm}%"))
            .OrderBy(p => p.Name)
            .Skip(recordsToSkip)
            .Take(pageSize)
            .ToListAsync();

            logger.LogInformation("{methodName} {searchTerm} {page}, {pageSize} returns {resultType} {result}",
                nameof(GetPaginatedClientsAsync), searchTerm, page, pageSize, nameof(List<Client>), result);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<string>> ClientNameLikeAsync(string searchTerm, byte page = 1, byte pageSize = 12)
    {
        int recordsToSkip = (page - 1) * pageSize;

        try
        {
            var result = await dbContext.Clients
                .Where(r => EF.Functions.Like(r.Name, $"%{searchTerm}%"))
                .OrderBy(p => p.Name)
                .Skip(recordsToSkip)
                .Take(pageSize)
                .Select(r => r.Name)
                .ToListAsync();

            logger.LogInformation("{methodName} {searchTerm} {page}, {pageSize} returns {resultType} {result}",
                nameof(GetPaginatedClientsAsync), searchTerm, page, pageSize, nameof(List<Client>), result);

            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}