using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Areas.Client.Models;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Models;

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
    public async Task<DataPageModel<MyThinkBook.Domain.Wms.Client>> GetAsync(byte page = 1, byte pageSize = 10, string sort = "")
    {
        return await clientRepository.GetPaginatedClientsAsync(page, pageSize);
    }

    [HttpPost]
    [Consumes(System.Net.Mime.MediaTypeNames.Application.Json)]
    public async Task<List<string>> SearchAsync([FromBody] ClientApiSearchRequest request)
    {
        return await clientRepository.ClientNameLikeAsync(request.SearchTerm, request.Page, request.PageSize);
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

