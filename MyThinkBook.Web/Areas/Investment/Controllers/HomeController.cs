using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Models;

namespace MyThinkBook.Web.Areas.Investment.Controllers;

[Area("Investment")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> logger;
    private readonly IPortfolioRepository portfolioRepository;

    public HomeController(ILogger<HomeController> logger, IPortfolioRepository portfolioRepository)
    {
        this.logger = logger;
        this.portfolioRepository = portfolioRepository;
    }

    public async Task<IActionResult> IndexAsync(byte page = 1, byte pageSize = 10, string sort="")
    {
        DataPageModel<Portfolio> paginatedPortfolio = await portfolioRepository.GetPaginatedPortfoliosAsync(page, pageSize);

        return View(paginatedPortfolio);
    }

    //public async Task<IActionResult> IndexAjax(byte page = 1, byte pageSize = 10, string sort = "")
    //{
    //    return View();
    //}
}
