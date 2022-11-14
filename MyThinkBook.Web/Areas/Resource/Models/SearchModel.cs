using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Areas.Resource.Models;

public record SearchModel
{
    private static readonly IList<Resource> emptyResourceList = ImmutableList.Create<Resource>();

    [Display(Name = "Search")]
    public string SearchTerm { get; set; } = string.Empty;

    public IList<Resource> CloudResources { get; set; } = emptyResourceList;

    public IList<Resource> LocalResources { get; set; } = emptyResourceList;
}

