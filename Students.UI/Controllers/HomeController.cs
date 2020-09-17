using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Students.BLL.Interfaces;
using Students.DAL;
using Students.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Students.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogin _login;
        private readonly ILoggerService _logger;

        public HomeController(ILogin login, ILoggerService logger)
        {
            _login = login;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["script"] = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Manager manager)
        {
            var redirectUri = "/dashboard";

            var r = _login.Get(manager.USERNAME, manager.PASSWORD);
            if (r != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,r.USERNAME),
                    new Claim(ClaimTypes.Sid,r.MANAGERID.ToString()),
                    new Claim(ClaimTypes.Role,"Manager"),
                    new Claim(ClaimTypes.Hash,r.TOKEN)
                };

                var userIndentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTime.UtcNow.AddDays(1),
                    RedirectUri = redirectUri
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(userIndentity), authProperties);

                await _logger.AddLog(new Log
                {
                    HOSTNAME = Request.GetDisplayUrl(),
                    HOSTADDRESS = HttpContext.Connection.RemoteIpAddress.ToString(),
                    MANAGERID = r.MANAGERID,
                    MESSAGE = "Giriş yapıldı."
                });

                return Redirect(redirectUri);
            }
            else
            {
                ViewData["script"] = "swal('Giriş','Hatalı Giriş','error')";
                return View();
            }
        }

        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await _logger.AddLog(new Log
            {
                HOSTNAME = Request.GetDisplayUrl(),
                HOSTADDRESS = HttpContext.Connection.RemoteIpAddress.ToString(),
                MANAGERID = int.Parse(User.Claims.Where(c => c.Type == ClaimTypes.Sid).Select(s => s.Value).SingleOrDefault()),
                MESSAGE = "Çıkış yapıldı."
            });

            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
