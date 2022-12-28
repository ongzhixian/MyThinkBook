using MyThinkBook.Domain.Wms;

namespace MyThinkBook.Web.Data;

public interface IClientRepository
{
    Task<int> SaveChangesAsync();

    void Add(Client item);
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

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }
}