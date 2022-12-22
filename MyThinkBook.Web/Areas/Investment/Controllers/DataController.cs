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
    private readonly IMessageQueueService messageQueueService;

    public DataController(ILogger<DataController> logger, IPositionRepository positionRepository, ISgxScrapingService sgxScrapingService, IMessageQueueService messageQueueService)
    {
        this.logger = logger;
        this.positionRepository = positionRepository;
        this.sgxScrapingService = sgxScrapingService;
        this.messageQueueService = messageQueueService;
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

        if (action == "Get Prices")
        {
            await sgxScrapingService.GetPricesAsync("U11");
        }

        if (action == "Send test message")
        {
            //messageQueueService.SendMessage("hello world");
            messageQueueService.Send("just send", "hello", "hello");
        }

        if (action == "Stop consumer1")
        {
            //messageQueueService.SendMessage("hello world");
            messageQueueService.StopConsuming("consumer1");
        }

        return View();
    }

    //public async Task<IActionResult> IndexAsync(int id, byte page = 1, byte pageSize = 10)
    //{
    //    await positionRepository.GetPaginatedPositionsAsync(id, page, pageSize);
    //    return View(id);
    //}
}
