using Dropbox.Api.Files;
using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Areas.Resource.Models;
using System.Collections.Immutable;

namespace MyThinkBook.Web.Areas.Resource.Controllers;

[Area("Resource")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> logger;

    public HomeController(ILogger<HomeController> logger)
    {
        this.logger = logger;
    }

    public IActionResult Index()
    {
        var resourceList = GetHardCodedResourceList();

        SearchModel searchModel = MakeSearchModel(resourceList);

        return View(searchModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Index([Bind("SearchTerm")] SearchModel searchModel)
    {
        if (ModelState.IsValid)
        {
            var resourceList = GetHardCodedResourceList().Where(r => r.Name.Contains(searchModel.SearchTerm, StringComparison.InvariantCultureIgnoreCase));
            var newSearchModel = MakeSearchModel(resourceList);
            newSearchModel.SearchTerm = searchModel.SearchTerm;
            return View(nameof(Index), newSearchModel);
        }

        return RedirectToAction(nameof(Index));
    }

    private static SearchModel MakeSearchModel(IEnumerable<Domain.Resource> resourceList)
    {
        return new SearchModel
        {
            CloudResources = resourceList
                .Where(r => r.Location == Domain.ResourceLocation.Cloud)
                .Select(r => new Models.Resource { Name = r.Name })
                .OrderBy(r => r.Name)
                .ToImmutableList(),

            LocalResources = resourceList
                .Where(r => r.Location == Domain.ResourceLocation.Local)
                .Select(r => new Models.Resource { Name = r.Name })
                .OrderBy(r => r.Name)
                .ToImmutableList(),
        };
    }

    private List<Domain.Resource> GetHardCodedResourceList()
    {
        return new List<Domain.Resource>
        {
            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "Github", Category = "API" },
            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "Gitlab", Category = "API" },

            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "Flickr", Category = "API" },

            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "Azure", Category = "API" },
            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "Google Cloud", Category = "API" },
            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "AWS", Category = "API" },

            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "Atlas MongoDb", Category = "Database" },
            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "Dropbox", Category = "Storage" },
            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "CloudAmqp", Category = "Messaging" },

            new Domain.Resource { Location = Domain.ResourceLocation.Cloud, Name = "GoDaddy", Category = "DNS" },

            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Ibm Mq", Category = "Messaging" },
            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Internet Information Services (IIS)", Category = "Web server" },
            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Minikube", Category = "Kubernetes" },

            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Splunk", Category = "Log" },

            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "elasticsearch", Category = "Search engine" },
            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "LogStash", Category = "Log processor" },
            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Kibana", Category = "Visualizer" },
            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Filebeat", Category = "Log forwarder" },

            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Grafana", Category = "Visualizer" },
            new Domain.Resource { Location = Domain.ResourceLocation.Local, Name = "Loki", Category = "Log processor" },
        };
    }
}
