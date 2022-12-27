using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Areas.Receive.Models;


public record ReceiveFormViewModel
{
    public IList<ReceiveEntry> ReceiveEntries { get; set; } = new List<ReceiveEntry>();


    public List<SelectListItem> UnitOfMeasureList { get; } = new List<SelectListItem>
    {
        //<option value="" disabled selected>Pick unit</option>
        new SelectListItem { Value = "", Text = "Pick unit", Disabled = true },
        new SelectListItem { Value = "1", Text = "Option 1" },
        new SelectListItem { Value = "2", Text = "Option 2" },
        new SelectListItem { Value = "3", Text = "Option 3"  },
    };
}

public record ReceiveEntry
{
    public string Name { get; set; } = string.Empty;
    
    public string Quantity { get; set; } = string.Empty;

    public string Unit { get; set; } = string.Empty;
}
