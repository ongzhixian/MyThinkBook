using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Research.Controllers;

[Area("Research")]
public class MachineLearningController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
