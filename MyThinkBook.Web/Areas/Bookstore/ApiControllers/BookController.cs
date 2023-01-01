using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Domain;
using MyThinkBook.Web.Areas.Bookstore.Models;
using MyThinkBook.Web.Data;
using System.Net.Mime;

namespace MyThinkBook.Web.Areas.Bookstore.ApiControllers;

[Route("api/bookstore/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> logger;
    private readonly IBookRepository bookRepository;

    public BookController(ILogger<BookController> logger, IEnumerable<IBookRepository> bookRepositories)
    {
        this.logger = logger;
        bookRepository = bookRepositories.First(r => r.GetType().Name == nameof(SqliteBookRepository));
    }

    [HttpPost]
    [Consumes(MediaTypeNames.Application.Json)]
    public async Task AddBookAsync([FromBody] AddBookRequest request)
    {
        var book = new MyThinkBook.Domain.Book();
        book.Title = request.BookTitle;
        book.InternationalStandardBookNumber = request.BookIsbn;
        book.Format = request.BookFormat;
        book.Authors = request.BookAuthors.Split().Select(m => new BookAuthor
        {
            FirstName = m.Trim()
        }).ToList();

        await bookRepository.AddAsync(book);

        logger.LogInformation("Request received: {request}", request);

    }
}
