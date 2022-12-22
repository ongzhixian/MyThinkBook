using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.Areas.Investment.Controllers;

[Area("Investment")]
public class DataController : Controller
{
    private readonly ILogger<DataController> logger;
    private readonly IPositionRepository positionRepository;
    private readonly ISgxScrapingService sgxScrapingService;

    public DataController(ILogger<DataController> logger, IPositionRepository positionRepository, ISgxScrapingService sgxScrapingService)
    {
        this.logger = logger;
        this.positionRepository = positionRepository;
        this.sgxScrapingService= sgxScrapingService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> IndexAsync(string action = "")
    {
        if (action == "Get SGX instruments")
        {
            await sgxScrapingService.GetInstrumentsAsync();
        }

        if (action == "Get MarketMetadata")
        {
            await sgxScrapingService.GetMarketMetadataAsync("U11");
        }

        return View();
    }

    //public async Task<IActionResult> IndexAsync(int id, byte page = 1, byte pageSize = 10)
    //{
    //    await positionRepository.GetPaginatedPositionsAsync(id, page, pageSize);
    //    return View(id);
    //}
}
