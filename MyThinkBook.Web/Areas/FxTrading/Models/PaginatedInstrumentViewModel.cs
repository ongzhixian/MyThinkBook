using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Domain.OandaApi;
using MyThinkBook.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Areas.FxTrading.Models;

public class PaginatedInstrumentViewModel
{
    public PaginatedDataModel<Instrument> PagedData { get; set; }

    [Display(Name = "Search", Description = "Search criteria")]
    public string SearchTerm { get; set; }

    [HiddenInput]
    public byte Page { get; set; }

    public PaginatedInstrumentViewModel(PaginatedDataModel<Instrument> pagedData, byte page)
    {
        this.PagedData = pagedData;

        this.Page = page;
    }
}
