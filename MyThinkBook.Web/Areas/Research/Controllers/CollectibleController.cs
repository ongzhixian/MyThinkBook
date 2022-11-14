using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Areas.Research.Models;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain;
using MyThinkBook.Web.Extensions;

namespace MyThinkBook.Web.Areas.Research.Controllers;

[Area("Research")]
public class CollectibleController : Controller
{
    private readonly ILogger<CollectibleController> logger;
    private readonly IHyperlinkRepository hyperlinkRepository;
    private readonly IUrlLinkRepository urlLinkRepository;

    public CollectibleController(ILogger<CollectibleController> logger
        , IHyperlinkRepository hyperlinkRepository
        , IUrlLinkRepository urlLinkRepository)
    {
        this.logger = logger;
        this.hyperlinkRepository = hyperlinkRepository;
        this.urlLinkRepository = urlLinkRepository;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult HyperlinkAnalytics()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> HyperlinkAnalyticsAsync(string action)
    {
        switch (action)
        {
            case "ToUrlLinks":
                List<UnprocessedHyperlink> unprocessedHyperlink = await hyperlinkRepository.GetUnprocessedAsync();

                unprocessedHyperlink.ForEach(async link =>
                {
                    try
                    {
                        Uri uri = new(link.Url);

                        await urlLinkRepository.UpsertAsync(new UrlLink()
                        {
                            UrlHash = uri.AsSHA256Base64(),
                            Url = link.Url,
                            UrlDomain = uri.DnsSafeHost,
                            Count = link.Count
                        });

                        await urlLinkRepository.SaveChangesAsync();

                        await hyperlinkRepository.UpdateUnprocessedHyperlinkAsync(link);
                    }
                    catch (Exception)
                    {
                        await hyperlinkRepository.UpdateUnprocessedHyperlinkAsync(link, HyperlinkStatus.Error);
                    }
                });

                //foreach (var item in unprocessedHyperlink)
                //{
                //    Uri u = new Uri(item.Url);
                //    UrlLink link = new()
                //    {
                //        Url = item.Url,
                //        Count = item.Count
                //    };
                //    urlLinkRepository.Add(link);
                //}
                return View();
            default:
                return View();
        }
    }

    public IActionResult Hyperlink()
    {
        return View(new HyperlinkViewModel());
    }

    [HttpPost]
    public async Task<IActionResult> HyperlinkAsync(HyperlinkViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            var entries = viewModel.Text.Split('\r', StringSplitOptions.RemoveEmptyEntries)
                .Where(r => !string.IsNullOrWhiteSpace(r));

            var savedEntriesCount = await SaveEntriesAsync(entries);

            ViewData["statusMessage"] = $"Saved {savedEntriesCount} links.";

            ModelState.Clear();

            return View(new HyperlinkViewModel());
        }

        ViewData["statusMessage"] = "No data";

        return View(new HyperlinkViewModel());
    }

    private async Task<int> SaveEntriesAsync(IEnumerable<string> entries)
    {
        var count = 0;

        var batchSize = 10;

        var batchCount = entries.BatchCount(batchSize);

        for (var i = 0; i < batchCount; i++)
        {
            var hyperlinkList = entries
                .Skip(i * batchSize)
                .Take(batchSize)
                .Where(entry => !string.IsNullOrWhiteSpace(entry))
                .Select(entry => new Hyperlink
                {
                    Url = entry.Trim()
                });

            count += await hyperlinkRepository.AddAsync(hyperlinkList);
        }

        return count;
    }
}
