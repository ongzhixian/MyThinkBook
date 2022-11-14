using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.Areas.FxTrading.Controllers;

[Area("FxTrading")]
public class DocumentController : Controller
{
    private readonly ILogger<DocumentController> logger;
    private readonly IDropboxService dropboxService;
    //private readonly IConfiguration configuration;
    //private readonly IMessagingModule messagingModule;
    
    public DocumentController(ILogger<DocumentController> logger, IDropboxService dropboxService)
    {
        this.logger = logger;
        this.dropboxService = dropboxService;

        //this.configuration = configuration;
        //this.messagingModule = messagingModule;

        //var client = new MongoClient(configuration["mongodb:minitools:ConnectionString"]);
        //var minitoolsdb = client.GetDatabase("minitools");
    }

    // GET: DocumentController
    public async Task<ActionResult> IndexAsync()
    {
        if (dropboxService.Oauth2TokenHasExpired)
        {
            // Bookmark where to return
            await dropboxService.BookmarkUrlAsync(Url.Action());

            // Then redirect user to Dropbox's authorization page
            return Redirect(dropboxService.AuthorizeUrl);
        }

        Domain.UsersGetCurrentAccountResponse? user = await dropboxService.GetCurrentAccountAsync();

        return View(user);
    }


    //// GET: DocumentController/Details/5
    //public ActionResult Details(int id)
    //{
    //    return View();
    //}

    // GET: DocumentController/Create
    //public ActionResult Create()
    //{
    //    return View();
    //}

    //// POST: DocumentController/Create
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Create(IFormCollection collection)
    //{
    //    try
    //    {
    //        logger.LogWarning("In Create HttpPost for DocumentController");
    //        PublishMessage();
    //        return RedirectToAction(nameof(Index));
    //    }
    //    catch
    //    {
    //        return View();
    //    }
    //}

    //private void PublishMessage()
    //{
    //    messagingModule.SendMessage("Hello from DocumentController");
        
    //}

    //// GET: DocumentController/Edit/5
    //public ActionResult Edit(int id)
    //{
    //    return View();
    //}

    //// POST: DocumentController/Edit/5
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Edit(int id, IFormCollection collection)
    //{
    //    try
    //    {
    //        return RedirectToAction(nameof(Index));
    //    }
    //    catch
    //    {
    //        return View();
    //    }
    //}

    //// GET: DocumentController/Delete/5
    //public ActionResult Delete(int id)
    //{
    //    return View();
    //}

    //// POST: DocumentController/Delete/5
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Delete(int id, IFormCollection collection)
    //{
    //    try
    //    {
    //        return RedirectToAction(nameof(Index));
    //    }
    //    catch
    //    {
    //        return View();
    //    }
    //}
}
