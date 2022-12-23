using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;

namespace MyThinkBook.Web.Areas.Investment.Controllers;

[Area("Investment")]
public class PortfolioController : Controller
{
    private readonly ILogger<PortfolioController> logger;
    private readonly IPositionRepository positionRepository;

    public PortfolioController(ILogger<PortfolioController> logger, IPositionRepository positionRepository)
    {
        this.logger = logger;
        this.positionRepository = positionRepository;
    }

    public async Task<IActionResult> IndexAsync(int id, byte page = 1, byte pageSize = 10)
    {
        Models.DataPageModel<Domain.Position> viewModel = await positionRepository.GetPaginatedPositionsAsync(id, page, pageSize);

        return View(viewModel);
    }
}
