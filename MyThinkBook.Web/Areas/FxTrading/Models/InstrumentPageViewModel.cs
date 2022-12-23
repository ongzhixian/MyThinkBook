using MyThinkBook.Web.Domain.OandaApi;
using MyThinkBook.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace MyThinkBook.Web.Areas.FxTrading.Models;

public class InstrumentPageViewModel
{
    public DataPageModel<Instrument> DataPage { get; set; }

    public InstrumentSearchFormViewModel FormModel { get; set; } = new();

    public InstrumentPageViewModel(DataPageModel<Instrument> dataPage, InstrumentSearchFormViewModel formModel)
    {
        DataPage = dataPage;
        FormModel = formModel;
    }

    public InstrumentPageViewModel(DataPageModel<Instrument> dataPage) : this(dataPage, new())
    {
    }

    public InstrumentPageViewModel() : this(new(), new())
    {
    }
}

public class InstrumentSearchFormViewModel
{
    [Display(Name = "Name contains", Description = "Search criteria")]
    public string SearchTerm { get; set; } = string.Empty;
}