using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;

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

    public async Task<IActionResult> IndexAsync()
    {
        IEnumerable<Domain.Portfolio> portfolioList = await portfolioRepository.GetPortfoliosAsync();

        return View(portfolioList);
    }
}
