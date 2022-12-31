using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Research.Controllers;

[Area("Research")]
public class IotController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
