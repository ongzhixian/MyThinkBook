using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Models;

namespace MyThinkBook.Web.Areas.Investment.Controllers;

[Area("Investment")]
public class HomeController : Controller
{
    ILogger<HomeController> logger;
    IPortfolioRepository portfolioRepository;

    public HomeController(ILogger<HomeController> logger, IPortfolioRepository portfolioRepository)
    {
        this.logger = logger;
        this.portfolioRepository = portfolioRepository;
    }

    public async Task<IActionResult> IndexAsync(byte page = 1, byte pageSize = 10)
    {
        PaginatedDataModel<Portfolio> paginatedPortfolio = await portfolioRepository.GetPaginatedPortfoliosAsync(page, pageSize);

        return View(paginatedPortfolio);
    }
}
