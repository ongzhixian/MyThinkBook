using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyThinkBook.Web.Tests;

internal class AsyncQueryProviderTestTrial
{
}


internal class TestAsyncQueryProvider<T> : IAsyncQueryProvider
{
    private readonly IQueryProvider queryProvider;

    internal TestAsyncQueryProvider(IQueryProvider queryProvider)
    {
        this.queryProvider = queryProvider;
    }

    public IQueryable CreateQuery(Expression expression)
    {
        return new TestAsyncEnumerable<T>(expression);
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        return new TestAsyncEnumerable<TElement>(expression);
    }

    public object? Execute(Expression expression)
    {
        return queryProvider.Execute(expression);
    }

    public TResult Execute<TResult>(Expression expression)
    {
        try
        {
            var result = queryProvider.Execute<TResult>(expression);

            return result;
        }
        catch (Exception)
        {

            throw;
        }

    }

    public TResult ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken = default)
    {
        try
        {
            var result = queryProvider.Execute<TResult>(expression);

            return result;
        }
        catch (Exception)
        {

            throw;
        }

        return Execute<TResult>(expression);
    }
}

internal class TestAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
{
    public TestAsyncEnumerable(IEnumerable<T> enumerable) : base(enumerable) { }

    public TestAsyncEnumerable(Expression expression) : base(expression) { }

    public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
    {
        return new TestAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
    }

    IQueryProvider IQueryable.Provider
    {
        get { return new TestAsyncQueryProvider<T>(this); }
    }
}

internal class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
{
    private readonly IEnumerator<T> enumerator;

    public TestAsyncEnumerator(IEnumerator<T> enumerator)
    {
        this.enumerator = enumerator;
    }

    public T Current => enumerator.Current;

    public ValueTask DisposeAsync()
    {
        enumerator.Dispose();

        return ValueTask.CompletedTask;
    }

    public ValueTask<bool> MoveNextAsync()
    {
        return ValueTask.FromResult(enumerator.MoveNext());
    }
}

//var queryableProviderMock = new Mock<IQueryProvider>();
//queryableProviderMock.As<INhQueryProvider>()
//.Setup(x => x.ExecuteAsync<IEnumerable<Entity>>(It.IsAny<Expression>(), It.IsAny<CancellationToken>()))
//.ReturnsAsync(entities);

/// <summary>
/// Plagerised from https://learn.microsoft.com/en-us/ef/ef6/fundamentals/testing/mocking
/// See also: https://stackoverflow.com/questions/39719258/idbasyncqueryprovider-in-entityframeworkcore
/// </summary>
/// <typeparam name="TEntity"></typeparam>

//internal class TestDbAsyncQueryProvider<TEntity> : IAsyncEnumerable<TEntity>
//{
//    private readonly IQueryProvider _inner;

//    internal TestDbAsyncQueryProvider(IQueryProvider inner)
//    {
//        _inner = inner;
//    }

//    public IQueryable CreateQuery(Expression expression)
//    {
//        return new TestDbAsyncEnumerable<TEntity>(expression);
//    }

//    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
//    {
//        return new TestDbAsyncEnumerable<TElement>(expression);
//    }

//    public object Execute(Expression expression)
//    {
//        return _inner.Execute(expression);
//    }

//    public TResult Execute<TResult>(Expression expression)
//    {
//        return _inner.Execute<TResult>(expression);
//    }

//    public Task<object> ExecuteAsync(Expression expression, CancellationToken cancellationToken)
//    {
//        return Task.FromResult(Execute(expression));
//    }

//    public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
//    {
//        return Task.FromResult(Execute<TResult>(expression));
//    }

//    public IAsyncEnumerator<TEntity> GetAsyncEnumerator(CancellationToken cancellationToken = default)
//    {
//        throw new NotImplementedException();
//    }
//}

//internal class TestDbAsyncEnumerable<T> : EnumerableQuery<T>, IDbAsyncEnumerable<T>, IQueryable<T>
//{
//    public TestDbAsyncEnumerable(IEnumerable<T> enumerable)
//        : base(enumerable)
//    { }

//    public TestDbAsyncEnumerable(Expression expression)
//        : base(expression)
//    { }

//    public IDbAsyncEnumerator<T> GetAsyncEnumerator()
//    {
//        return new TestDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
//    }

//    IDbAsyncEnumerator IDbAsyncEnumerable.GetAsyncEnumerator()
//    {
//        return GetAsyncEnumerator();
//    }

//    IQueryProvider IQueryable.Provider
//    {
//        get { return new TestDbAsyncQueryProvider<T>(this); }
//    }
//}

//internal class TestDbAsyncEnumerator<T> : IDbAsyncEnumerator<T>
//{
//    private readonly IEnumerator<T> _inner;

//    public TestDbAsyncEnumerator(IEnumerator<T> inner)
//    {
//        _inner = inner;
//    }

//    public void Dispose()
//    {
//        _inner.Dispose();
//    }

//    public Task<bool> MoveNextAsync(CancellationToken cancellationToken)
//    {
//        return Task.FromResult(_inner.MoveNext());
//    }

//    public T Current
//    {
//        get { return _inner.Current; }
//    }

//    object IDbAsyncEnumerator.Current
//    {
//        get { return Current; }
//    }
//}


////

//public class AsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
//{
//    public AsyncEnumerable(Expression expression)
//        : base(expression) { }

//    public IAsyncEnumerator<T> GetEnumerator() =>
//        new AsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
//}

//public class AsyncEnumerator<T> : IAsyncEnumerator<T>
//{
//    private readonly IEnumerator<T> enumerator;

//    public AsyncEnumerator(IEnumerator<T> enumerator) =>
//        this.enumerator = enumerator ?? throw new ArgumentNullException();

//    public T Current => enumerator.Current;

//    public void Dispose() { }

//    public Task<bool> MoveNext(CancellationToken cancellationToken) =>
//        Task.FromResult(enumerator.MoveNext());
//}