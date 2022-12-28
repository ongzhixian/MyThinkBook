using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyThinkBook.Web.Areas.Client.ApiControllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly ILogger<ClientController> logger;
    private readonly IClientRepository clientRepository;

    public ClientController(ILogger<ClientController> logger, IClientRepository clientRepository)
    {
        this.logger = logger;
        this.clientRepository = clientRepository;
    }

    [HttpGet]
    public async Task<Models.DataPageModel<MyThinkBook.Domain.Wms.Client>> GetAsync(byte page = 1, byte pageSize = 10, string sort = "")
    {
        return await clientRepository.GetPaginatedClientsAsync(page, pageSize);
    }

    public async Task<List<MyThinkBook.Domain.Wms.Client>> SearchAsync(string searchTerm, byte page = 1, byte pageSize = 10)
    {
        return await clientRepository.NameContainsAsync(searchTerm, page, pageSize);
    }

    //// GET api/<ApplicationController>/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    //// POST api/<ApplicationController>
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT api/<ApplicationController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<ApplicationController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
