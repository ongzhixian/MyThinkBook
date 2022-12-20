using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
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

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

logger.Debug("init main");

try
{
    Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().FullName);
    Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().GetName().Name);

    var builder = WebApplication.CreateBuilder(args);

    AddConfiguration(builder);

    builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));

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

    builder.Services.AddOptions<DropboxOptions>()
        .Bind(builder.Configuration.GetSection(DropboxOptions.LocalConfigurationKey))
        .Bind(builder.Configuration.GetSection(DropboxOptions.SettingsConfigurationKey))
        .ValidateDataAnnotations()
        .ValidateOnStart();

    builder.Services.AddDbContext<MvcMovieContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));

    builder.Services.AddDbContext<MyThinkBookDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MyThinkBookDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'MyThinkBookDbContextSqlite' not found.")));

    builder.Services.AddDbContext<InvestmentDbContext>(options =>
        options
        .UseSqlite(builder.Configuration.GetConnectionString("InvestmentDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'InvestmentDbContextSqlite' not found."))
        .EnableSensitiveDataLogging());

    //builder.Services.AddDbContext<IdentityDataContext>(options =>
    //    options.UseSqlite(builder.Configuration.GetConnectionString("MyThinkBookDbContextSqlite") ?? throw new InvalidOperationException("Connection string 'MyThinkBookDbContextSqlite' not found.")));


    //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    //builder.Services.AddAuthentication().AddMicrosoftAccount(microsoftOptions =>
    //{
    //    microsoftOptions.ClientId = builder.Configuration["authentication:microsoft:clientId"];
    //    microsoftOptions.ClientSecret = builder.Configuration["authentication:microsoft:clientSecret"];
    //});

    builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(options =>
        {
            options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
            options.SlidingExpiration = true;
            options.AccessDeniedPath = "/Forbidden/";
        });

    //builder.Services
    //    .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    //    .AddEntityFrameworkStores<IdentityDataContext>();



    RegisterSingleton(builder);

    //builder.Services.Add(new ServiceDescriptor(typeof(IMiniToolsDataContext), typeof(MiniToolsDataContext), ServiceLifetime.Scoped));
    //builder.Services.AddScoped<IMiniToolsDataContext, MiniToolsDataContext>(sp =>
    //{
    //    return new MiniToolsDataContext(builder.Configuration[ConfigurationKeysLoader.CloudMongoDbMiniToolsConnectionString]!);
    //});
    //builder.Services.AddScoped<IMiniToolsDataContext, MiniToolsDataContext>();
    builder.Services.AddScoped<IAppStateItemRepository, AppStateItemRepository>();
    builder.Services.AddScoped<IHyperlinkRepository, HyperlinkRepository>();
    builder.Services.AddScoped<IUrlLinkRepository, UrlLinkRepository>();
    builder.Services.AddScoped<IPortfolioRepository, PortfolioRepository>();


    builder.Services.AddHttpLogging(log =>
    {
        log.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    });

    builder.Services.AddW3CLogging(logging =>
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


    builder.Services.AddHttpClient<IFxTradingEngineProxyService, FxTradingEngineProxyService>();
    //builder.Services.AddHttpClient<IGraphQLService, GraphQLService>();
    builder.Services.AddHttpClient<IDropboxService, DropboxService>();

    //builder.Services.AddHostedService<RabbitMqListener>();
    //builder.Services.AddHostedService<FxTradingListener>();

    // Add services to the container.
    builder.Services.AddControllersWithViews();




    builder.Services.Configure<HealthCheckPublisherOptions>(options =>
    {
        options.Period = TimeSpan.FromSeconds(3);
    });

    builder.Services.AddMemoryCache();

    var healthCheckBuilder = builder.Services.AddHealthChecks();
    //healthCheckBuilder.AddCheck<FxTradingEngineProxyHealthCheck>("FxTradingEngineProxyHealthCheck");

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
    }

    app.UseStatusCodePagesWithReExecute("/http-status/{0}");

    app.UseHttpsRedirection();

    app.UseResponseCaching();

    app.UseResponseCompression();

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

    // FxTrading/Chat => FxTrading/Home/Chat

    app.MapControllerRoute(
        name: "HttpStatus",
        pattern: "/http-status/{id?}",
        defaults: new { area = "", controller = "HttpStatus", action = "Index" });


    app.MapControllerRoute(
        name: "FxTradingWith",
        pattern: "/FxTrading/{controller=Home}/{action=Index}/{id?}",
        defaults: new { area = "FxTrading" });

    app.MapControllerRoute(
        name: "FxTrading",
        pattern: "/FxTrading/{action=Index}",
        defaults: new { area = "FxTrading", controller = "Home" });

    app.MapControllerRoute(
        name: "Resource",
        pattern: "/Resource/{id}",
        defaults: new { area = "Resource", controller = "Resource", action = "Index" });

    app.MapControllerRoute(
        name: "MyArea",
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



static void RegisterSingleton(WebApplicationBuilder builder)
{
    builder.Services.AddSingleton<IHealthCheckPublisher, HealthCheckPublisher>();

    builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider => serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);
    //builder.Services.AddSingleton<IDataContextConnectionStrings, DataContextConnectionStrings>();

    //builder.Services.AddSingleton<IDropboxFileProvider, DropboxFileProvider>();


    //builder.Services.AddSingleton<IRabbitMqFactory, RabbitMqFactory>();
    //builder.Services.AddSingleton<IMessagingModule, RabbitMqMessagingModule>();

    //builder.Services.AddSingleton<IServerAddressService, ServerAddressService>();
}

static void AddConfiguration(WebApplicationBuilder builder)
{
    var myThinkBookConfigPath = Path.Join(Environment.GetEnvironmentVariable("USERPROFILE") ?? ".", "mythinkbook.config.json");

    builder.Configuration.AddJsonFile(myThinkBookConfigPath, false, true);

    builder.Configuration.AddUserSecrets(System.Reflection.Assembly.GetExecutingAssembly(), true, true);
}
