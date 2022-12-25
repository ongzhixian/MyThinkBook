using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Models;

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

    public async Task<IActionResult> IndexAsync(byte page = 1, byte pageSize = 10)
    {
        //await bookRepository.AddAsync(new Domain.Book
        //{
        //    Title = "Some new title",
        //    Author = "some new author"
        //});

        var books = await bookRepository.ListAsync();

        DataPageModel<Book> viewModel = new DataPageModel<Book>(books, page, pageSize);

        return View(viewModel);
    }
}
