using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Areas.Receive.Models;

namespace MyThinkBook.Web.Areas.Receive.Controllers;

[Area("Receive")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> logger;

    public HomeController(ILogger<HomeController> logger)
    {
        this.logger = logger;
    }

    public IActionResult Index()
    {
        ReceiveFormViewModel viewModel = new ReceiveFormViewModel();

        viewModel.ReceiveEntries = new List<ReceiveEntry>
        {
            new ReceiveEntry { Name = "Item 1", Quantity = "100", Unit = "1" },
            new ReceiveEntry { Name = "Item 2", Quantity = "200", Unit = "2" },
            new ReceiveEntry { Name = "Item 3", Quantity = "300", Unit = "3" }
        };

        return View(viewModel);
    }

    [HttpPost]
    public IActionResult Index(ReceiveFormViewModel viewModel)
    {
        logger.LogInformation("viewModel {viewModel}", viewModel);
        return View(viewModel);
    }

}
