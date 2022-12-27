using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Inventory.Controllers;

[Area("Inventory")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
