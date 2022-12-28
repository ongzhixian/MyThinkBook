using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Client.Controllers;

[Area("Client")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
