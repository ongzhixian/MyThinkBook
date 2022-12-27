using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.WmsSetup.Controllers;

[Area("WmsSetup")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
