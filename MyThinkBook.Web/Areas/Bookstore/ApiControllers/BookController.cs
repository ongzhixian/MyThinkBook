using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Areas.Bookstore.Models;

namespace MyThinkBook.Web.Areas.Bookstore.ApiControllers;

[Route("api/bookstore/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> logger;

    public BookController(ILogger<BookController> logger)
    {
        this.logger = logger;
    }

    [HttpPost]
    [Consumes(System.Net.Mime.MediaTypeNames.Application.Json)]
    public void AddBook([FromBody] AddBookRequest request)
    {
        logger.LogInformation("Request received: {request}", request);

    }
}
