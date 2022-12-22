using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MvcMovie.Data;
using MyThinkBook.Data.MongoDb;
using MyThinkBook.Web.Data;
using MyThinkBook.Web.HealthChecks;
using MyThinkBook.Web.Hubs;
using MyThinkBook.Web.Options;
using MyThinkBook.Web.Services;
using NLog;
using NLog.Web;
using Microsoft.AspNetCore.HttpLogging;
using MyThinkBook.Web.HostedServices;

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

    builder.Services.AddMemoryCache();

    builder.Services.AddResponseCompression(options =>
    {
        options.EnableForHttps = true;
    });

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
}

void AddHostedServices(IServiceCollection services)
{
    services.AddHostedService<CloudAmqpListener>();
    //builder.Services.AddHostedService<FxTradingListener>();
}

void AddHttpClientServices(IServiceCollection services)
{
    services.AddHttpClient<IFxTradingEngineProxyService, FxTradingEngineProxyService>();
    //builder.Services.AddHttpClient<IGraphQLService, GraphQLService>();
    services.AddHttpClient<IDropboxService, DropboxService>();
    services.AddHttpClient<ISgxScrapingService, SgxScrapingService>();
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
        options.UseSqlite(configuration.GetConnectionString("MyThinkBookDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'MyThinkBookDbContextSqlite' not found.")));

    services.AddDbContextPool<InvestmentDbContext>(options =>
        options
        .UseSqlite(configuration.GetConnectionString("InvestmentDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'InvestmentDbContextSqlite' not found."))
        .EnableSensitiveDataLogging());

    //builder.Services.AddDbContext<IdentityDataContext>(options =>
    //    options.UseSqlite(builder.Configuration.GetConnectionString("MyThinkBookDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'MyThinkBookDbContextSqlite' not found.")));
}

void MapApplicationsSettings(ConfigurationManager configuration, IServiceCollection services)
{
    services.Configure<MongoDbSettings>(configuration.GetSection("MongoDbSettings"));

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
