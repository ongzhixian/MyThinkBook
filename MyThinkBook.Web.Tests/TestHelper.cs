using Moq.Protected;
using Moq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Query;
using System.Net.Sockets;

namespace MyThinkBook.Web.Tests;

internal static class TestHelper
{
    public static HttpClient getMockHttpClient()
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

    public static HttpClient getMockHttpClient(HttpResponseMessage httpResponseMessage)
    {
        var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

        httpMessageHandlerMock
            .Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(httpResponseMessage);

        return new HttpClient(httpMessageHandlerMock.Object);
    }

    //private HttpClient getMockApiHealthHttpClient()
    //{
    //    var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

    //    httpMessageHandlerMock
    //        .Protected()
    //        .Setup<Task<HttpResponseMessage>>("SendAsync",
    //            ItExpr.Is<HttpRequestMessage>(m => m.RequestUri!.Equals($"{url}/api/health")),
    //            ItExpr.IsAny<CancellationToken>())
    //        .ReturnsAsync(new HttpResponseMessage
    //        {
    //            Content = new StringContent("somecontent")
    //        });

    //    return new HttpClient(httpMessageHandlerMock.Object);
    //}


    //public static void SetupMockDbSet<T>(Mock<DbSet<T>> mockDbSet, IQueryable<T> queryableData) where T : class
    //{
    //    mockDbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryableData.Provider);
    //    mockDbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryableData.Expression);
    //    mockDbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryableData.ElementType);
    //    mockDbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryableData.GetEnumerator());

    //    //mockDbSet.As<IAsyncEnumerable<T>>().Setup(x => x.GetAsyncEnumerator(It.IsAny<CancellationToken>())).Returns(new TestAsyncEnumerator<T>(queryableData.GetEnumerator()));
    //    //mockDbSet.As<IQueryable<T>>().Setup(x => x.Provider).Returns(new TestAsyncQueryProvider<T>(queryableData.Provider));
    //}
}