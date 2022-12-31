using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Areas.Bookstore.Models;

namespace MyThinkBook.Web.Areas.Bookstore.Controllers;

[Area("Bookstore")]
public class BookController : Controller
{
    private readonly ILogger<BookController> logger;

    public BookController(ILogger<BookController> logger)
    {
        this.logger = logger;
    }

    public IActionResult Index()
    {
        return View(new SearchViewModel());
    }

    [HttpPost]
    public IActionResult Index(SearchViewModel viewModel)
    {
        if (ModelState.IsValid) 
        {
            logger.LogInformation("{viewModel}", viewModel);
        }

        return View();
    }
}
