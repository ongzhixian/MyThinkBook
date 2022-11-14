using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Moq.Protected;
using MyThinkBook.Web.Areas.FxTrading.Models;
using System.Net.Sockets;

namespace MyThinkBook.Web.Services.Tests
{
    [TestClass()]
    public class FxTradingEngineProxyServiceTests
    {
        private readonly Mock<ILogger<FxTradingEngineProxyService>> logger = new();
        private readonly Mock<IConfiguration> mockConfiguration = new();
        private const string url = "http://localhost:31000";

        [TestInitialize]
        public void InitializeTest()
        {
            mockConfiguration.Setup(m => m[It.IsAny<string>()]).Returns(url);
        }

        [TestMethod()]
        public void FxTradingEngineProxyServiceTest()
        {
            var httpClient = getMockHttpClient(); // Creating HttpClient via using mocks

            //var httpClient = getHttpClientMock(); // Creating HttpClient via private implementation of HttpMessageHandler

            FxTradingEngineProxyService service = new(logger.Object, mockConfiguration.Object, httpClient);

            Assert.IsNotNull(service);
        }

        [TestMethod()]
        public async Task PingAsyncTestAsync()
        {
            var httpClient = getMockApiHealthHttpClient();

            FxTradingEngineProxyService service = new(logger.Object, mockConfiguration.Object, httpClient);

            var result = await service.PingAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual("somecontent", result);
        }


        [TestMethod()]
        public async Task PingAsyncWithExceptionTest()
        {
            var httpClient = getMockApiHealthHttpClientThrowsException();

            FxTradingEngineProxyService service = new(logger.Object, mockConfiguration.Object, httpClient);

            var result = await service.PingAsync();

            Assert.IsNotNull(result);

            //logger.Verify(x => x.Log(
            //    It.IsAny<LogLevel>(),
            //    It.IsAny<EventId>(),
            //    It.IsAny<It.IsAnyType>(),
            //    It.IsAny<Exception>(),
            //    (Func<It.IsAnyType, Exception, string>)It.IsAny<object>()), Times.Once);
            
            logger.Verify(x => x.Log(
                LogLevel.Warning,
                0,
                It.IsAny<It.IsAnyType>(),
                null,
                (Func<It.IsAnyType, Exception?, string>)It.IsAny<object>()
                ), Times.Once);

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod()]
        public async Task GetInstrumentsAsyncTestAsync()
        {
            var httpClient = getMockApiInstrumentHttpClient();

            FxTradingEngineProxyService service = new(logger.Object, mockConfiguration.Object, httpClient);

            var result = await service.GetInstrumentsAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod()]
        public async Task GetInstrumentsAsyncTestAsync_WhenHttpClientThrowsException()
        {
            var httpClient = getMockApiInstrumentHttpClientThrowsException();

            FxTradingEngineProxyService service = new(logger.Object, mockConfiguration.Object, httpClient);

            var result = await service.GetInstrumentsAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod()]
        public async Task GetInstrumentsAsyncTestAsync_WhenHttpClientThrowsHttpRequestException()
        {
            var httpClient = getMockApiInstrumentHttpClientThrowsHttpRequestException();

            FxTradingEngineProxyService service = new(logger.Object, mockConfiguration.Object, httpClient);

            var result = await service.GetInstrumentsAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod()]
        public async Task GetInstrumentsAsyncTestAsync_WhenHttpClientThrowsHttpRequestExceptionWithSocketException()
        {
            var httpClient = getMockApiInstrumentHttpClientThrowsHttpRequestExceptionWithSocketException();

            FxTradingEngineProxyService service = new(logger.Object, mockConfiguration.Object, httpClient);

            var result = await service.GetInstrumentsAsync();

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }

        private HttpClient getMockApiInstrumentHttpClientThrowsHttpRequestExceptionWithSocketException()
        {
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            var httpRequestException = new HttpRequestException(null, new SocketException((int)SocketError.ConnectionRefused));

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m => m.RequestUri!.Equals($"{url}/api/instrument")),
                    ItExpr.IsAny<CancellationToken>())
                .ThrowsAsync(httpRequestException);

            return new HttpClient(httpMessageHandlerMock.Object);
        }


        private HttpClient getMockApiInstrumentHttpClientThrowsHttpRequestException()
        {
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m => m.RequestUri!.Equals($"{url}/api/instrument")),
                    ItExpr.IsAny<CancellationToken>())
                .ThrowsAsync(new HttpRequestException());

            return new HttpClient(httpMessageHandlerMock.Object);
        }

        private HttpClient getMockApiInstrumentHttpClientThrowsException()
        {
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m => m.RequestUri!.Equals($"{url}/api/instrument")),
                    ItExpr.IsAny<CancellationToken>())
                .ThrowsAsync(new Exception());

            return new HttpClient(httpMessageHandlerMock.Object);
        }

        private HttpClient getMockApiInstrumentHttpClient()
        {
            List<Instrument> instrumentList = new();

            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m => m.RequestUri!.Equals($"{url}/api/instrument")),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(instrumentList))
                });

            

            return new HttpClient(httpMessageHandlerMock.Object);
        }

        private HttpClient getMockApiHealthHttpClientThrowsException()
        {
            SocketException socketException = new SocketException((int)SocketError.ConnectionRefused);

            HttpRequestException ex = new HttpRequestException("someMessage", socketException, System.Net.HttpStatusCode.InternalServerError);

            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m => m.RequestUri!.Equals($"{url}/api/health")),
                    ItExpr.IsAny<CancellationToken>())
                .ThrowsAsync(ex);
                

            return new HttpClient(httpMessageHandlerMock.Object);
        }

        private HttpClient getMockApiHealthHttpClient()
        {
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.Is<HttpRequestMessage>(m => m.RequestUri!.Equals($"{url}/api/health")),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    Content = new StringContent("somecontent")
                });

            return new HttpClient(httpMessageHandlerMock.Object);
        }

        private HttpClient getMockHttpClient()
        {
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage());

            return new HttpClient(httpMessageHandlerMock.Object);
        }

        private HttpClient getHttpClientMock() => new HttpClient(new HttpMessageHandlerMock());

        private class HttpMessageHandlerMock : HttpMessageHandler
        {
            protected override Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                return Task.FromResult(new HttpResponseMessage());
            }
        }
    }
}