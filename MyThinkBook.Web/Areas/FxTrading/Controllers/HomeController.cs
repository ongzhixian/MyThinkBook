using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using MyThinkBook.Web.Areas.FxTrading.Models;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain.FxTrading;
using MyThinkBook.Web.Domain.OandaApi;
using MyThinkBook.Web.Models;
using MyThinkBook.Web.Services;
using System.Collections.Immutable;
using System.Linq;

namespace MyThinkBook.Web.Areas.FxTrading.Controllers;

[Area("FxTrading")]
public class HomeController : Controller
{
    public readonly ILogger<HomeController> logger;
    private readonly IFxTradingEngineProxyService fxTradingEngineProxyService;
    //private readonly IGraphQLService graphQLService;
    private readonly IOandaRestApiService oandaRestApiService;

    private readonly MyThinkBookDbContext myThinkBookDbContext;

    public HomeController(ILogger<HomeController> logger, IFxTradingEngineProxyService fxTradingEngineProxyService, MyThinkBookDbContext myThinkBookDbContext, IOandaRestApiService oandaRestApiService)
    {
        this.logger = logger;
        this.fxTradingEngineProxyService = fxTradingEngineProxyService;
        this.myThinkBookDbContext = myThinkBookDbContext;
        this.oandaRestApiService = oandaRestApiService;

        //this.graphQLService = graphQLService;

    }

    public async Task<IActionResult> IndexAsync()
    {
        try
        {
            var vm = new IndexViewModel();
            
            vm.OpportunitiesCount = 0;
            //vm.ActiveTrades.Add(new TradeOrder { Id = 234 });

            // await dropboxFileProvider.TestAsync();

            //var instruments = await fxTradingEngineProxyService.GetInstrumentsAsync();

            //await this.graphQLService.TestAsync();

            //var channel = GrpcChannel.ForAddress("http://localhost:50051");t
            //var client = new Greeter.GreeterClient(channel);
            //var response = await client.SayHelloAsync(new HelloRequest { Name = "World" });
            //Console.WriteLine(response.Message);

            await Task.CompletedTask;

            return View(vm);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<IActionResult> AccountsAsync()
    {
        var accountsResponse = await oandaRestApiService.GetAccountsAsync();
        
        return View(accountsResponse);
    }

    public async Task<IActionResult> AccountAsync()
    {
        var accountSummary = await oandaRestApiService.GetAccountSummaryAsync();

        return View(accountSummary);
    }

    public async Task<IActionResult> InstrumentsAsync(byte page = 1, byte pageSize = 12)
    {
        InstrumentsResponse? instrumentsResponse = await oandaRestApiService.GetInstrumentsAsync();

        var instrumentList = instrumentsResponse.InstrumentList.OrderBy(r => r.Name);

        var pagedData = new DataPageModel<Domain.OandaApi.Instrument>(instrumentList, page, pageSize);

        InstrumentPageViewModel viewModel = new InstrumentPageViewModel(pagedData);

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> InstrumentsAsync(InstrumentSearchFormViewModel formModel, byte page = 1, byte pageSize = 12)
    {
        if (ModelState.IsValid)
        {
            var instrumentsResponse = await oandaRestApiService.GetInstrumentsAsync();

            var instrumentList = instrumentsResponse.InstrumentList
                .Where(r => r.Name.Contains(formModel.SearchTerm, StringComparison.InvariantCultureIgnoreCase))
                .OrderBy(r => r.Name);

            var pagedData = new DataPageModel<Domain.OandaApi.Instrument>(instrumentList, page, pageSize);

            var viewModel = new InstrumentPageViewModel(pagedData, formModel);

            ModelState.Clear();

            return View(viewModel);
        }

        return View();
    }

    public IActionResult Chat()
    {
        return View();
    }

    public IActionResult PlaceOrder()
    {

        return View(new OrderEntry());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult PlaceOrder(OrderEntry orderEntry)
    {
        if (ModelState.IsValid)
        {

        }

        return View(orderEntry);
    }

    public IActionResult TradeInstrument(byte page = 1, byte pageSize = 20)
    {
        int recordsToSkip = (page - 1) * pageSize;

        var records = myThinkBookDbContext.TradeInstruments.Skip(recordsToSkip).Take(pageSize).OrderBy(r => r.Name).ToImmutableList();

        int totalRecordCount = myThinkBookDbContext.TradeInstruments.Count();

        int recordStart = ((page - 1) * pageSize) + 1;

        int recordEnd = ((page - 1) * pageSize) + records.Count;

        var data = new XxxPaginatedDataModel<TradeInstrument>
        {
            CurrentPage = page,
            PageSize = pageSize,
            TotalRecordCount = totalRecordCount,
            TotalPageCount = (totalRecordCount / pageSize) + ((totalRecordCount % pageSize) > 0 ? 1 : 0),
            Data = records,
            RecordStart = recordStart,
            RecordEnd = recordEnd
        };

        return View(data);
    }
}


