using CustomCookie.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CustomCookie.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, model.UserName)
        };

        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity),
            new AuthenticationProperties
            {
                IsPersistent = true,
                ExpiresUtc = DateTime.Now.AddMinutes(20)
            });

        return RedirectToAction("Index", "Home");
    }
}
