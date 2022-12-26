using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Research.Controllers;

[Area("Research")]
public class CanvasController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SimpleSpringy()
    {
        return View();
    }

    public IActionResult InteractiveSpringy()
    {
        return View();
    }
}
