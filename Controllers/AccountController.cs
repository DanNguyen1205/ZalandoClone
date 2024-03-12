using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ZaunShop.Business;
using ZaunShop.Models;

namespace ZaunShop.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(CredentialViewModel credential)
        {

            //Verify credentials
            if (credential.Username == "Admin" && credential.Password == "Password")
            {
                //Creating security context
                var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name, "Admin"),
                    new Claim(ClaimTypes.Email, "admin@mywebsite.com"),
                    new Claim("Admin", "true"),
                };
                                             //MyCookieAuth identity type
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                                                //MyCookieAuth identity scheme
                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);


                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyCookieAuth");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}

