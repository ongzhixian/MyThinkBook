using Microsoft.AspNetCore.Mvc;
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
    public void AddBook([FromBody] AddBookRequest request)
    {
        logger.LogInformation("Request received: {request}", request);

    }
}
