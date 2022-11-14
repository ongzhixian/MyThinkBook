using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Models;
using System.Diagnostics;
using static Dropbox.Api.Paper.UserOnPaperDocFilter;

namespace MyThinkBook.Web.Controllers;

public class HttpStatusController : Controller
{
    private readonly ILogger<HttpStatusController> logger;

    public HttpStatusController(ILogger<HttpStatusController> logger)
    {
        this.logger = logger;
    }

    public IActionResult Index(int id)
    {
        var requestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;

        // There's a HttpStatusCode enum!
        // System.Net.HttpStatusCode.OK

        // /Views/HttpStatus/HttpStatuss404.cshtml
        // /Views/Shared/HttpStatuss404.cshtml
        //if (!System.IO.File.Exists($"Areas/Resource/Views/Resource/{id}.cshtml"))
        //{
        //    logger.LogInformation("{id} resource page missing; return default resource page.", id);
        //    return View(nameof(Index), id);
        //}
        //return View($"HttpStatus{id}");

        HttpStatusViewModel viewModel = new HttpStatusViewModel();
        viewModel.RequestId = requestId;
        viewModel.HttpStatusCode = id;

        return View(nameof(Index), viewModel);
    }
}
