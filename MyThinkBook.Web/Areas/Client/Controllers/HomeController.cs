using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;

namespace MyThinkBook.Web.Areas.Client.Controllers;

[Area("Client")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> logger;
    private readonly IClientRepository clientRepository;

    public HomeController(ILogger<HomeController> logger, IClientRepository clientRepository)
    {
        this.logger = logger;
        this.clientRepository = clientRepository;
    }

    public async Task<IActionResult> IndexAsync(byte page = 1, byte pageSize = 10)
    {
        logger.LogInformation("{page}, {pageSize}", page, pageSize);

        Web.Models.DataPageModel<MyThinkBook.Domain.Wms.Client> viewModel = await clientRepository.GetPaginatedClientsAsync(page, pageSize);

        return View(viewModel);
    }
}
