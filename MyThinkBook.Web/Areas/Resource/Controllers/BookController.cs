using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;

namespace MyThinkBook.Web.Areas.Research.Controllers;

[Area("Resource")]
public class BookController : Controller
{
    private readonly ILogger<BookController> logger;
    private readonly IBookRepository bookRepository;

    public BookController(ILogger<BookController> logger, IBookRepository bookRepository)
    {
        this.logger = logger;
        this.bookRepository = bookRepository;
    }

    public async Task<IActionResult> IndexAsync()
    {
        List<Domain.Book> books = await bookRepository.ListAsync();

        return View(books);
    }
}
