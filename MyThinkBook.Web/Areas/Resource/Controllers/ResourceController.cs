using Microsoft.AspNetCore.Mvc;

namespace MyThinkBook.Web.Areas.Resource.Controllers;

[Area("Resource")]
public class ResourceController : Controller
{
    private readonly ILogger<ResourceController> logger;

    public ResourceController(ILogger<ResourceController> logger)
    {
        this.logger = logger;
    }

    public IActionResult Index(string id)
    {
        // Note: View files are search in the following locations:
        // /Areas/Resource/Views/Resource/{id}.cshtml
        // /Areas/Resource/Views/Shared/{id}.cshtml
        // /Views/Shared/{id}.cshtml

        ViewData["Title"] = id;

        if (!System.IO.File.Exists($"Areas/Resource/Views/Resource/{id}.cshtml"))
        {
            logger.LogInformation("{id} resource page missing; return default resource page.", id);

            return View(nameof(Index), id);
        }

        // var services = HttpContext.RequestServices;

        logger.LogInformation("Return {id} resource page.", id);

        var viewModel = GetViewModelForResource(id.ToLowerInvariant());

        return View(id, viewModel);
    }

    private object GetViewModelForResource(string id)
    {
        switch (id)
        {
            case "github":
                return new object();
            default:
                return new object();
        }

    }
}
