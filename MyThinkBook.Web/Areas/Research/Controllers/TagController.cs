using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Research.Controllers;

[Area("Research")]
public class TagController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tag()
    {
        return View();
    }

    public IActionResult Relation()
    {
        return View();
    }
}
