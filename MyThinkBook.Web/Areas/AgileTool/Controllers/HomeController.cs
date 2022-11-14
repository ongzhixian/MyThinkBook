using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.AgileTool.Controllers;

[Area("AgileTool")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
