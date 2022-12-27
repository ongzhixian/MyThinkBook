using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Wms.Controllers;

[Area("Wms")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
