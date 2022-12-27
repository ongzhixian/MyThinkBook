using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Send.Controllers;

[Area("Send")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
