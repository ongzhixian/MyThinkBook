using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyThinkBook.Web.Options;
using MyThinkBook.Web.Services;

namespace MyThinkBook.Web.Api;

[Route("api/[controller]")]
[ApiController]
public class DropboxController : ControllerBase
{
    private readonly ILogger<DropboxController> logger;
    private readonly IDropboxService dropboxService;

    public DropboxController(ILogger<DropboxController> logger, IDropboxService dropboxService)
    {
        this.logger = logger;
        this.dropboxService = dropboxService;
    }

    [HttpGet("/api/Dropbox/Authorize")]
    public async Task<IActionResult> AuthorizeAsync([FromQuery] string code)
    {
        await dropboxService.ExchangeCodeForBearerTokenAsync(code);

        var bookmarkUrl = await dropboxService.GetBookmarkUrlAsync();
        
        if (!string.IsNullOrEmpty(bookmarkUrl))
        {
            await dropboxService.ClearBookmarkUrlAsync();

            logger.LogInformation("Redirect to {bookmarkUrl}", bookmarkUrl);
            return Redirect(bookmarkUrl);
        }

        logger.LogInformation("Redirect to default");
        return RedirectToAction("Index", "Document", new { area = "FxTrading" });
    }
}
