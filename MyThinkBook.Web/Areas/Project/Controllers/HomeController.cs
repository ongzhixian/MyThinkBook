using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Project.Controllers;

[Area("Project")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    // GET: Project/Create
    public IActionResult Create()
    {
        return View();
    }

}
