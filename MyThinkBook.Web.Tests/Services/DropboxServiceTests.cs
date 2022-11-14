using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using Moq.Protected;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Domain.FxTrading;
using MyThinkBook.Web.Options;
using MyThinkBook.Web.Tests;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace MyThinkBook.Web.Services.Tests;

[TestClass()]
public class DropboxServiceTests
{
    private readonly Mock<ILogger<DropboxService>> mockLogger = new();
    private readonly Mock<IConfiguration> mockConfiguration = new();
    private readonly Mock<IAppStateItemRepository> mockAppStateItemRepository = new();
    private readonly Mock<IOptions<DropboxOptions>> mockDropboxOptions = new();
    //private readonly HttpClient httpClient = TestHelper.getMockHttpClient(); // Creating HttpClient via using mocks

    [TestInitialize]
    public void InitializeTest()
    {
        mockConfiguration.Setup(m => m["dropbox:myThinkBook:appKey"]).Returns("some app key");
        mockConfiguration.Setup(m => m["dropbox:myThinkBook:appSecret"]).Returns("some app secret");
        mockConfiguration.Setup(m => m["Dropbox:RedirectUri"]).Returns("some redirect uri");

        //TestHelper.SetupMockDbSet(mockAppStateItemDbSet, appStateItemData.AsQueryable());
        //mockMyThinkBookDbContext.Setup(m => m.AppStateItems).Returns(mockAppStateItemDbSet.Object);
    }

    [TestMethod()]
    public void DropboxServiceTest()
    {
        var service = GetServiceObject();

        Assert.IsNotNull(service);
    }

    [TestMethod()]
    public async Task GetCurrentAccountAsyncTestAsync()
    {
        var httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
        {
            Content = new StringContent(
            JsonSerializer.Serialize(new UsersGetCurrentAccountResponse
            {
                Email = "some email"
            }),
            Encoding.UTF8,
            MediaTypeNames.Application.Json)
        };

        HttpClient httpClient = TestHelper.getMockHttpClient(httpResponseMessage);

        var service = GetServiceObject(httpClient);

        var account = await service.GetCurrentAccountAsync();

        Assert.IsNotNull(account);
        Assert.AreEqual("some email", account!.Email);
    }

    [TestMethod()]
    public async Task ExchangeCodeForBearerTokenAsyncTestAsync()
    {
        var httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
        {
            Content = new StringContent(
            JsonSerializer.Serialize(new Oauth2TokenResponse
            {
                AccessToken = "some access token",
                AccountId = "some account id",
                ExpiresInSeconds = 1239,
                TokenType = "token type",
                UID = "some uid"
            }),
            Encoding.UTF8,
            MediaTypeNames.Application.Json)
        };

        HttpClient httpClient = TestHelper.getMockHttpClient(httpResponseMessage);

        var service = GetServiceObject(httpClient);

        await service.ExchangeCodeForBearerTokenAsync("some code");

        mockAppStateItemRepository.Verify(m => m.SaveChangesAsync(), Times.Once());
    }

    [TestMethod()]
    public async Task BookmarkUrlAsyncTestAsync()
    {
        mockAppStateItemRepository.Setup(m => m.KeyEqualsAsync(It.IsAny<string>())).ReturnsAsync(new AppStateItem
        {
            Key = "some key",
            Value = "some value"
        });

        mockAppStateItemRepository.Setup(m => m.SaveChangesAsync()).ReturnsAsync(1);

        var service = GetServiceObject();

        var result = await service.BookmarkUrlAsync("some url");

        Assert.AreEqual(1, result);
    }

    [TestMethod()]
    public async Task GetBookmarkUrlAsyncTestAsync_WhenNoBookmarkUrlExists()
    {
        var service = GetServiceObject();

        var result = await service.GetBookmarkUrlAsync();

        Assert.IsNull(result);
    }

    [TestMethod()]
    public async Task GetBookmarkUrlAsyncTestAsync_WhenBookmarkUrlExists()
    {
        mockAppStateItemRepository.Setup(m => m.KeyEqualsAsync(It.IsAny<string>())).ReturnsAsync(new AppStateItem
        {
            Key = "some key",
            Value = "some value"
        });

        var service = GetServiceObject();

        var result = await service.GetBookmarkUrlAsync();

        Assert.IsNotNull(result);
        Assert.AreEqual("some value", result);
    }

    [TestMethod()]
    public async Task ClearBookmarkUrlAsyncTestAsync()
    {
        mockAppStateItemRepository.Setup(m => m.DeleteAsync(It.IsAny<string>())).ReturnsAsync(1);

        var service = GetServiceObject();

        var result = await service.ClearBookmarkUrlAsync();

        Assert.AreEqual(1, result);
    }

    private DropboxService GetServiceObject(HttpClient? httpClient = null)
    {
        httpClient ??= TestHelper.getMockHttpClient();

        DropboxOptions dropboxOptions = new DropboxOptions
        {
            AuthorizeUrl = "https://www.dropbox.com/oauth2/authorize",
            ApiBaseUrl = "https://api.dropbox.com",
            RedirectUrl = "https://localhost:5401/api/Dropbox/Authorize",
            AppKey = "some key",
            AppSecret = "some secret"
        };

        //Enumerable.Empty<T>().AsQueryable();
        List<AppStateItem> appStateItems = new List<AppStateItem>
        {
            new AppStateItem { Key = IDropboxService.DropboxAccessTokenKey, Value = "some access token value" },
            new AppStateItem { Key = IDropboxService.DropboxExpiryDateKey, Value = "2022-12-19" }
        };

        mockAppStateItemRepository.Setup(m => m.KeyContains(It.IsAny<string>())).Returns(appStateItems.AsQueryable());

        mockDropboxOptions.Setup(m => m.Value).Returns(dropboxOptions);

        return new DropboxService(mockLogger.Object, mockConfiguration.Object, httpClient, mockAppStateItemRepository.Object, mockDropboxOptions.Object);
    }
}