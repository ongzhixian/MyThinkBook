using MyThinkBook.Web.Data;
using MyThinkBook.Web.Domain;
using System.Text.RegularExpressions;

namespace MyThinkBook.Web.Services;

public interface ISgxScrapingService
{
    Task GetInstrumentsAsync(DateTime? now = null);

    Task GetMarketMetadataAsync(string exchangeInstrumentCode);
}

public class SgxScrapingService : ISgxScrapingService
{
    private readonly ILogger<SgxScrapingService> logger;
    private readonly IConfiguration configuration;
    private readonly HttpClient httpClient;
    private readonly IInstrumentRepository instrumentRepository;

    public SgxScrapingService(ILogger<SgxScrapingService> logger, IConfiguration configuration, HttpClient httpClient, IInstrumentRepository instrumentRepository)
    {
        this.logger = logger;
        this.configuration = configuration;
        this.httpClient = httpClient;
        this.instrumentRepository = instrumentRepository;
    }

    public async Task GetInstrumentsAsync(DateTime? now = null)
    {
        now ??= DateTime.Now;

        string url = $"https://links.sgx.com/FileOpen/{Uri.EscapeDataString(now.Value.ToString("dd MMM yyyy"))}.ashx?App=ISINCode&FileID=1";

        var response = await httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();

        string content = await response.Content.ReadAsStringAsync();

        string seedDataDirectory = configuration["DataDirectory:SeedData"];

        if (!System.IO.Directory.Exists(seedDataDirectory))
        {
            System.IO.Directory.CreateDirectory(seedDataDirectory);
        }

        string isinFilePath = System.IO.Path.Join(seedDataDirectory, $"isin-{now.Value.ToString("yyyy-MM-dd")}.txt");
        
        System.IO.File.WriteAllText(isinFilePath, content);

        var lines = content.Split('\r').Skip(1);

        var recordRegex = new Regex("(?<Name>.{50})(?<Status>.{10})(?<Isin>.{20})(?<Code>.{10})(?<Counter>.+)", RegexOptions.CultureInvariant | RegexOptions.Compiled);

        var sgxInstruments = new List<SgxInstrument>();

        //Dictionary<string, int> isinCounter = new Dictionary<string, int>();

        foreach (var line in lines)
        {
            var match = recordRegex.Match(line);

            if (match.Success)
            {
                sgxInstruments.Add(new SgxInstrument
                {
                    Name = match.Groups["Name"].Value.Trim(),
                    Status = match.Groups["Status"].Value.Trim(),
                    Isin = match.Groups["Isin"].Value.Trim(),
                    Code = match.Groups["Code"].Value.Trim(),
                    Counter = match.Groups["Counter"].Value.Trim(),
                });

                //var isin = match.Groups["Isin"].Value.Trim();
                //if (isinCounter.ContainsKey(isin))
                //{
                //    isinCounter[match.Groups["Isin"].Value.Trim()] += 1;
                //}
                //else
                //{
                //    isinCounter[match.Groups["Isin"].Value.Trim()] = 1;
                //}
            }
        }

        // var more = isinCounter.Where(r => r.Value > 1).ToList();

        IEnumerable<Instrument> instrumentList = sgxInstruments.Select(r => new Instrument
        {
            Isin = r.Isin,
            Code = r.Code,
            Name = r.Name
        });

        foreach (var batchOfInstruments in instrumentList.Chunk(100))
        {
            await instrumentRepository.UpsertInstrumentsAsync(batchOfInstruments);
        }
    }

    public async Task GetMarketMetadataAsync(string exchangeInstrumentCode)
    {
        string url = $"https://api.sgx.com/marketmetadata/v2?stock-code={exchangeInstrumentCode}";

        var response = await httpClient.GetAsync(url);

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadFromJsonAsync<MarketMetadataResponse>();

    }
}