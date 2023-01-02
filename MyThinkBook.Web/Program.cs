using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MvcMovie.Data;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.HealthChecks;
using MyThinkBook.Web.Hubs;
using MyThinkBook.Web.Options;
using MyThinkBook.Web.Services;
using NLog;
using NLog.Web;
using Microsoft.AspNetCore.HttpLogging;
using MyThinkBook.Web.HostedServices;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

logger.Debug("init main");

try
{
    //var entryAssembly = System.Reflection.Assembly.GetEntryAssembly();
    //var entryAssemblyName = entryAssembly?.GetName();
    //if (entryAssemblyName?.Name == "ef")
    //{
    //}
    //var serviceProvider = new ServiceCollection()
    //.AddLogging()
    //.AddSingleton<IFooService, FooService>()
    //.AddSingleton<IBarService, BarService>()
    //.BuildServiceProvider();
    //IConfiguration config = new ConfigurationBuilder()
    //.AddJsonFile("appsettings.json")
    //.AddEnvironmentVariables()
    //.Build();

    // I think the problem with the EF Core error is because we are using WebApplication.CreateBuilder()
    var builder = WebApplication.CreateBuilder(args);

    ReadApplicationSettings(builder.Configuration);

    MapApplicationsSettings(builder.Configuration, builder.Services);

    AddDbContexts(builder.Configuration, builder.Services);

    AddAuthenticationServices(builder.Services);

    AddIdentityServices(builder.Services);

    AddLoggingServices(builder.Services);

    AddHealthCheckServices(builder.Services);

    builder.Services.AddStackExchangeRedisCache(options =>
    {
        options.Configuration = $"{builder.Configuration["redis:myThinkBook:url"]},password={builder.Configuration["redis:myThinkBook:password"]}";
        options.InstanceName = builder.Configuration["redis:myThinkBook:instanceName"];
    });

    // Redis data store
    // builder.Services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect($"{builder.Configuration["redis:myThinkBook:url"]},password={builder.Configuration["redis:myThinkBook:password"]}"));

    // MongoDb
    // MongoDbContext: IMongoDbContext
    builder.Services.AddSingleton<MyThinkBook.Web.Data.IMongoDbContext, MyThinkBook.Web.Data.MongoDbContext>();
    builder.Services.AddSingleton<IBookStoreMongoDbContext, BookStoreMongoDbContext>();
    builder.Services.AddSingleton<IBookRepository, MongoDbBookRepository>();
    

    // AddFileProviderServices
    //builder.Services.AddSingleton<IDropboxFileProvider, DropboxFileProvider>();

    // AddServerInformationServices
    //builder.Services.AddSingleton<IServerAddressService, ServerAddressService>();

    // AddMessengingServices
    //builder.Services.AddSingleton<IRabbitMqFactory, RabbitMqFactory>();
    //builder.Services.AddSingleton<IMessagingModule, RabbitMqMessagingModule>();
    builder.Services.AddSingleton<IMessageQueueService, CloudAmqpMessagingQueue>();

    // AddDataContextServices
    // builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider => serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);
    //builder.Services.AddSingleton<IDataContextConnectionStrings, DataContextConnectionStrings>();
    //builder.Services.Add(new ServiceDescriptor(typeof(IMiniToolsDataContext), typeof(MiniToolsDataContext), ServiceLifetime.Scoped));
    //builder.Services.AddScoped<IMiniToolsDataContext, MiniToolsDataContext>(sp =>
    //{
    //    return new MiniToolsDataContext(builder.Configuration[ConfigurationKeysLoader.CloudMongoDbMiniToolsConnectionString]!);
    //});

    AddDataRepositories(builder.Services);

    AddHttpClientServices(builder.Services);

    AddHostedServices(builder.Services);

    //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    builder.Services.AddControllersWithViews();

    // See: https://learn.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-7.0
    //builder.Services.AddControllersWithViews()
    //    .ConfigureApiBehaviorOptions(options =>
    //    {
    //        // To preserve the default behavior, capture the original delegate to call later.
    //        var builtInFactory = options.InvalidModelStateResponseFactory;

    //        options.InvalidModelStateResponseFactory = context =>
    //        {
    //            var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<Program>>();

    //            // Perform logging here.
    //            // ...


    //            // Invoke the default behavior, which produces a ValidationProblemDetails response.
    //            // To produce a custom response, return a different implementation of IActionResult instead.
    //            return builtInFactory(context);
    //        };
    //    });

    builder.Services.AddDistributedMemoryCache();

    builder.Services.AddMemoryCache();

    builder.Services.AddResponseCompression(options =>
    {
        options.EnableForHttps = true;
    });

    builder.Services.AddResponseCaching();

    builder.Services.AddSignalR();

    builder.Services.AddGrpc();

    builder.Logging.ClearProviders();

    builder.Host.UseNLog();

    var app = builder.Build();

    app.UseW3CLogging();

    // UseHttpLogging logs information about incoming (not outgoing) HTTP requests and HTTP responses;
    app.UseHttpLogging();

    app.MapHealthChecks("/health");

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        //app.UseDeveloperExceptionPage();
        //app.UseExceptionHandler("/Home/Error");

        //builder.Services.AddDatabaseDeveloperPageExceptionFilter();
        //builder.Services.AddProblemDetails();
    }
    else // Production
    {
        app.UseExceptionHandler("/Home/Error");

        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();

        app.UseResponseCompression();
    }

    app.UseStatusCodePagesWithReExecute("/http-status/{0}");

    app.UseHttpsRedirection();

    // app.UseCors();

    app.UseResponseCaching();

    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    //// https://localhost:5401/Resource/Home/Search
    //var rewriteOptions = new RewriteOptions()
    //      .AddRedirect(@"^/Resource/Home/Search", "Resource");

    //app.UseRewriter(rewriteOptions);

    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        var context = services.GetRequiredService<MyThinkBookDbContext>();

        context.Database.EnsureCreated();

        // context.Database.Migrate(); // Apply pending migrations
    }

    var cookiePolicyOptions = new CookiePolicyOptions
    {
        MinimumSameSitePolicy = SameSiteMode.Lax
    };

    app.UseCookiePolicy(cookiePolicyOptions);

    app.MapControllerRoute(
        name: "HttpStatus",
        pattern: "/http-status/{id?}",
        defaults: new { area = "", controller = "HttpStatus", action = "Index" });

    app.MapControllerRoute(
        name: "FxTradingControllerAction",
        pattern: "/FxTrading/{controller=Home}/{action=Index}/{id?}",
        defaults: new { area = "FxTrading" });

    app.MapControllerRoute(
        name: "FxTradingActionOnly",
        pattern: "/FxTrading/{action=Index}",
        defaults: new { area = "FxTrading", controller = "Home" });

    app.MapControllerRoute(
        name: "ResourceControllerAction",
        pattern: "/Resource/{controller=Home}/{action=Index}/{id?}",
        defaults: new { area = "Resource" });

    app.MapControllerRoute(
        name: "Resource",
        pattern: "/Resource/{id}",
        defaults: new { area = "Resource", controller = "Resource", action = "Index" });

    app.MapControllerRoute(
        name: "GenericExistingArea",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    //app.MapRazorPages();

    app.MapHub<ChatHub>("/chatHub");

    app.MapHub<FxTradingHub>("/fxTradingHub");

    //app.MapGrpcService<GreeterService>();

    // 

    app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}

void AddHealthCheckServices(IServiceCollection services)
{
    services.AddSingleton<IHealthCheckPublisher, HealthCheckPublisher>();

    services.AddHealthChecks();

    // Add other custom health checks
    //var healthCheckBuilder = services.AddHealthChecks();
    //healthCheckBuilder.AddCheck<FxTradingEngineProxyHealthCheck>("FxTradingEngineProxyHealthCheck");
}

void AddDataRepositories(IServiceCollection services)
{
    //builder.Services.AddScoped<IMiniToolsDataContext, MiniToolsDataContext>();
    services.AddScoped<IAppStateItemRepository, AppStateItemRepository>();
    services.AddScoped<IHyperlinkRepository, HyperlinkRepository>();
    services.AddScoped<IUrlLinkRepository, UrlLinkRepository>();
    services.AddScoped<IPortfolioRepository, PortfolioRepository>();
    services.AddScoped<IPositionRepository, PositionRepository>();
    services.AddScoped<IInstrumentRepository, InstrumentRepository>();

    services.AddScoped<IClientRepository, ClientRepository>();
    services.AddScoped<IBookRepository, BookSqliteRepository>();
}

void AddHostedServices(IServiceCollection services)
{
    services.AddHostedService<CloudAmqpListener>();
    //services.AddHostedService<OandaPriceStreamer>();
    //builder.Services.AddHostedService<FxTradingListener>();
}

void AddHttpClientServices(IServiceCollection services)
{
    services.AddHttpClient<IFxTradingEngineProxyService, FxTradingEngineProxyService>();
    //builder.Services.AddHttpClient<IGraphQLService, GraphQLService>();
    services.AddHttpClient<IDropboxService, DropboxService>();
    services.AddHttpClient<ISgxScrapingService, SgxScrapingService>();
    services.AddHttpClient<IOandaRestApiService, OandaRestApiService>();
    services.AddHttpClient<IOandaStreamApiService, OandaStreamApiService>();
}

void AddLoggingServices(IServiceCollection services)
{
    services.AddHttpLogging(log =>
    {
        log.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    });

    services.AddW3CLogging(logging =>
    {
        // Log all W3C fields
        logging.LoggingFields = W3CLoggingFields.All;
        //logging.AdditionalRequestHeaders.Add("x-forwarded-for");
        //logging.AdditionalRequestHeaders.Add("x-client-ssl-protocol");
        //logging.FileSizeLimit = 5 * 1024 * 1024;
        //logging.RetainedFileCountLimit = 2;
        //logging.FileName = "MyLogFile";
        //logging.LogDirectory = @"C:\logs";
        //logging.FlushInterval = TimeSpan.FromSeconds(2);
    });

}

void AddIdentityServices(IServiceCollection services)
{
    //builder.Services
    //    .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    //    .AddEntityFrameworkStores<IdentityDataContext>();
}

void AddAuthenticationServices(IServiceCollection services)
{
    //builder.Services.AddAuthentication().AddMicrosoftAccount(microsoftOptions =>
    //{
    //    microsoftOptions.ClientId = builder.Configuration["authentication:microsoft:clientId"];
    //    microsoftOptions.ClientSecret = builder.Configuration["authentication:microsoft:clientSecret"];
    //});

    services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
            options.SlidingExpiration = true;
            options.AccessDeniedPath = "/Forbidden/";
        });
}

void AddDbContexts(ConfigurationManager configuration, IServiceCollection services)
{
    services.AddDbContext<MvcMovieContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("MvcMovieContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));

    services.AddDbContext<MyThinkBookDbContext>(options =>
        options.UseSqlite(configuration.GetConnectionString("MyThinkBookSqliteDbContext") ?? throw new InvalidOperationException("Connection string 'MyThinkBookSqliteDbContext' not found.")));

    services.AddDbContextPool<InvestmentDbContext>(options =>
        options
        .UseSqlite(configuration.GetConnectionString("InvestmentSqliteDbContext") ?? throw new InvalidOperationException("Connection string 'InvestmentSqliteDbContext' not found."))
        .EnableSensitiveDataLogging());

    services.AddDbContextPool<WmsDbContext>(options => options
        .UseSqlite(configuration.GetConnectionString("WmsSqliteDbContext") ?? throw new InvalidOperationException("Connection string 'WmsSqliteDbContext' not found."))
        .EnableSensitiveDataLogging());

    services.AddDbContextPool<BookstoreDbContext>(options => options
        .UseSqlite(configuration.GetConnectionString("BookstoreSqliteDbContext") ?? throw new InvalidOperationException("Connection string 'BookstoreSqliteDbContext' not found."))
        .EnableSensitiveDataLogging());

    //builder.Services.AddDbContext<IdentityDataContext>(options =>
    //    options.UseSqlite(builder.Configuration.GetConnectionString("MyThinkBookDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'MyThinkBookDbContextSqlite' not found.")));
}

void MapApplicationsSettings(ConfigurationManager configuration, IServiceCollection services)
{
    //services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));

    //builder.Services.Configure<DropboxOptions>(options => {
    //    var settingsSection = builder.Configuration.GetSection(DropboxOptions.ConfigurationKey);
    //    var secretsSection = builder.Configuration.GetSection(DropboxOptions.AppConfigurationKey);
    //    options.AuthorizeUrl = settingsSection.GetValue<string>("AuthorizeUrl");
    //    options.ApiBaseUrl = settingsSection.GetValue<string>("ApiBaseUrl");
    //    options.RedirectUrl = settingsSection.GetValue<string>("RedirectUrl");

    //    options.RedirectUrl = settingsSection.GetValue<string>("RedirectUrl");
    //    options.RedirectUrl = settingsSection.GetValue<string>("RedirectUrl");
    //    //options.Url = Configuration.GetSection("WebTarget").GetValue<string>("WebURL", string.Empty);
    //});

    // Same but no validation; If both bindings have same keys, the last one wins.
    //builder.Services.Configure<DropboxOptions>(builder.Configuration.GetSection(DropboxOptions.ConfigurationKey));
    //builder.Services.Configure<DropboxOptions>(builder.Configuration.GetSection(DropboxOptions.AppConfigurationKey));

    services.AddOptions<DropboxOptions>()
        .Bind(configuration.GetSection(DropboxOptions.LocalConfigurationKey))
        .Bind(configuration.GetSection(DropboxOptions.SettingsConfigurationKey))
        .ValidateDataAnnotations()
        .ValidateOnStart();

    services.AddOptions<CloudAmqpOptions>()
        .Bind(configuration.GetSection(CloudAmqpOptions.LocalConfigurationKey))
        .Bind(configuration.GetSection(CloudAmqpOptions.SettingsConfigurationKey))
        .ValidateDataAnnotations()
        .ValidateOnStart();

    services.AddOptions<OandaOptions>()
        .Bind(configuration.GetSection(OandaOptions.LocalConfigurationKey))
        .Bind(configuration.GetSection(OandaOptions.SettingsConfigurationKey))
        .ValidateDataAnnotations()
        .ValidateOnStart();

    // Todo
    services.AddOptions<MongoDbOptions>()
        .Bind(configuration.GetSection(MongoDbOptions.LocalConfigurationKey))
        .Bind(configuration.GetSection(MongoDbOptions.SettingsConfigurationKey))
        .ValidateDataAnnotations()
        .ValidateOnStart();

    
    foreach (var connectionStringConfiguration in configuration.GetSection("ConnectionStrings").AsEnumerable().Where(r => r.Key.EndsWith("SqliteDbContext")))
    {
        var dbContextName = connectionStringConfiguration.Key.Split(':', StringSplitOptions.RemoveEmptyEntries).LastOrDefault();

        services.AddOptions<SqliteDbOptions>(dbContextName)
            .Configure(option =>
            {
                option.ConnectionString = connectionStringConfiguration.Value ?? throw new ArgumentNullException(connectionStringConfiguration.Key);
            })
            .ValidateDataAnnotations()
            .ValidateOnStart();
    }

    services.Configure<HealthCheckPublisherOptions>(options =>
    {
        options.Period = TimeSpan.FromSeconds(3);
    });
}

void ReadApplicationSettings(ConfigurationManager configuration)
{
    var myThinkBookConfigPath = Path.Join(Environment.GetEnvironmentVariable("USERPROFILE") ?? ".", "mythinkbook.config.json");

    configuration.AddJsonFile(myThinkBookConfigPath, false, true);

    configuration.AddUserSecrets(System.Reflection.Assembly.GetExecutingAssembly(), true, true);
}
