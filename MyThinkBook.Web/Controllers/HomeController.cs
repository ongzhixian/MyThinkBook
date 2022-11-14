using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MyThinkBook.Web.Models;

namespace MyThinkBook.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("In home {time}", DateTime.Now);

        return View();
    }

    public async Task<IActionResult> PrivacyAsync()
    {
        if (User.Identity != null && !User.Identity.IsAuthenticated)
        {
            return await OwnerAutomaticSignIn();
        }

        return View();
    }

    private async Task<IActionResult> OwnerAutomaticSignIn()
    {
        string userEmail = "zhixian@hotmail.com";
        string userName = "zhixian";
        string userFullName = "ONG ZHI XIAN";
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, userName),
            new Claim(ClaimTypes.Email, userEmail),
            new Claim("FullName", userFullName),
            new Claim(ClaimTypes.GivenName, "Zhixian"),
            new Claim(ClaimTypes.Role, "Administrator"),
        };

        var claimsIdentity = new ClaimsIdentity(
            claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var authProperties = new AuthenticationProperties
        {
            //AllowRefresh = <bool>,
            // Refreshing the authentication session should be allowed.

            //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
            // The time at which the authentication ticket expires. A 
            // value set here overrides the ExpireTimeSpan option of 
            // CookieAuthenticationOptions set with AddCookie.

            //IsPersistent = true,
            // Whether the authentication session is persisted across 
            // multiple requests. When used with cookies, controls
            // whether the cookie's lifetime is absolute (matching the
            // lifetime of the authentication ticket) or session-based.

            //IssuedUtc = <DateTimeOffset>,
            // The time at which the authentication ticket was issued.

            //RedirectUri = <string>
            // The full path or absolute URI to be used as an http 
            // redirect response value.
        };

        if (HttpContext != null)
        {
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
        }

        return RedirectToAction("Index", "Home", new { Area="" });
    }

    public async Task<IActionResult> LogOut()
    {
        if (HttpContext != null)
        {
            // Clear the existing external cookie
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        // Use this to handle any exception that occur.

        //var requestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
        //string exceptionMessage = string.Empty;

        //var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

        //if (exceptionHandlerPathFeature?.Error is FileNotFoundException)
        //{
        //    exceptionMessage = "The file was not found.";
        //}

        //if (exceptionHandlerPathFeature?.Path == "/")
        //{
        //    exceptionMessage ??= string.Empty;
        //    exceptionMessage += " Page: Home.";
        //}


        // TASK: Add an integration test to test when Activity.Current and HttpContent is not null
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier });
    }
}
