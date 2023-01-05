using Microsoft.Extensions.Logging;
using Moq;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyThinkBook.Web.Domain.FxTrading;
using MyThinkBook.Web.Areas.FxTrading.Models;

namespace MyThinkBook.Web.Areas.FxTrading.Controllers.Tests;

[TestClass()]
public class HomeControllerTests
{
    private readonly Mock<ILogger<HomeController>> logger = new();
    private readonly Mock<IFxTradingEngineProxyService> fxTradingEngineProxyService = new();
    //private readonly Mock<IGraphQLService> graphQLService = new();

    private readonly Mock<MyThinkBookDbContext> mockMyThinkBookDbContext = new();
    private readonly Mock<DbSet<TradeInstrument>> mockTradeInstrumentDbSet = new();
    private readonly Mock<IOandaRestApiService> mockOandaRestApiService = new();
    private readonly Mock<IOandaStreamApiService> mockOandaStreamApiService = new();
    private readonly List<TradeInstrument> sampleData = new List<TradeInstrument>
    {
        new TradeInstrument
        {
            Name = "sampleInstrument1",
            DisplayName = "Sample Instrument 1",
            Type = "some instrument type",
            AssetClass = "some asset class",
            MinimumTradeSize = 1.2M
        }
    };

    [TestInitialize]
    public void InitializeTest()
    {
        SetupMockDbSet(mockTradeInstrumentDbSet, sampleData.AsQueryable());

        mockMyThinkBookDbContext.Setup(m => m.TradeInstruments).Returns(mockTradeInstrumentDbSet.Object);
    }

    private void SetupMockDbSet<T>(Mock<DbSet<T>> mockDbSet, IQueryable<T> queryableData) where T : class
    {
        mockDbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryableData.Provider);
        mockDbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryableData.Expression);
        mockDbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryableData.ElementType);
        mockDbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryableData.GetEnumerator());
    }

    [TestMethod()]
    public void HomeControllerTest()
    {
        var controller = new HomeController(logger.Object, fxTradingEngineProxyService.Object, It.IsAny<MyThinkBookDbContext>(), mockOandaRestApiService.Object, mockOandaStreamApiService.Object);

        Assert.IsNotNull(controller);
    }

    [TestMethod()]
    public async Task IndexAsyncTestAsync()
    {
        var controller = new HomeController(logger.Object, fxTradingEngineProxyService.Object, It.IsAny<MyThinkBookDbContext>(), mockOandaRestApiService.Object, mockOandaStreamApiService.Object);

        var result = await controller.IndexAsync();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod()]
    public void ChatTest()
    {
        var controller = new HomeController(logger.Object, fxTradingEngineProxyService.Object, It.IsAny<MyThinkBookDbContext>(), mockOandaRestApiService.Object, mockOandaStreamApiService.Object);

        var result = controller.Chat();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod()]
    public void PlaceOrderTest()
    {
        HomeController controller = new HomeController(logger.Object, fxTradingEngineProxyService.Object, It.IsAny<MyThinkBookDbContext>(), mockOandaRestApiService.Object, mockOandaStreamApiService.Object);

        var result = controller.PlaceOrder();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod()]
    public void TradeInstrumentTest()
    {
        var controller = new HomeController(logger.Object, fxTradingEngineProxyService.Object, mockMyThinkBookDbContext.Object, mockOandaRestApiService.Object, mockOandaStreamApiService.Object);

        var result = controller.TradeInstrument();

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));
    }

    [TestMethod()]
    public void TradeInstrumentTest_WhenPageSize()
    {
        var controller = new HomeController(logger.Object, fxTradingEngineProxyService.Object, mockMyThinkBookDbContext.Object, mockOandaRestApiService.Object, mockOandaStreamApiService.Object);

        var result = controller.TradeInstrument(pageSize: 1);

        Assert.IsNotNull(result);
        Assert.IsInstanceOfType(result, typeof(ViewResult));

        var model = ((ViewResult)result).Model;
        Assert.IsNotNull(model);
        Assert.IsInstanceOfType(model, typeof(XxxPaginatedDataModel<TradeInstrument>));

        var paginatedDataModel = model as XxxPaginatedDataModel<TradeInstrument> ?? throw new InvalidCastException();
        Assert.AreEqual(1, paginatedDataModel.CurrentPage);
        Assert.AreEqual(1, paginatedDataModel.PageSize);
        Assert.AreEqual(1, paginatedDataModel.RecordStart);
        Assert.AreEqual(1, paginatedDataModel.RecordEnd);
        Assert.AreEqual(1, paginatedDataModel.TotalPageCount);
        Assert.AreEqual(1, paginatedDataModel.TotalRecordCount);

        Assert.IsNotNull(paginatedDataModel.Data);
        Assert.AreEqual(1, paginatedDataModel.Data!.Count);

        var instrument = paginatedDataModel.Data!.First();
        Assert.AreEqual("sampleInstrument1", instrument.Name);
        Assert.AreEqual("Sample Instrument 1", instrument.DisplayName);
        Assert.AreEqual("some instrument type", instrument.Type);
        Assert.AreEqual("some asset class", instrument.AssetClass);
        Assert.AreEqual(1.2M, instrument.MinimumTradeSize);
    }
}