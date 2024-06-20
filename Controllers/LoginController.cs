using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurante.Contexto;
using Restaurante.Models;
using System.Security.Claims;

namespace Restaurante.Controllers
{
    public class LoginController : Controller
    {
        private readonly MyContext _context;

        public LoginController(MyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated) 
            {
                if (User.IsInRole("Administrador"))
                {
                    return RedirectToAction("Index", "Administrador");
                }
                else
                {
                    return RedirectToAction("Index", "Recepcionista");
                }
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string user, string pass)
        {
            var usuario = await _context.Usuarios
                .Where(x => x.User == user && x.Pass == pass)
                .FirstOrDefaultAsync();

            if(usuario == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                await SetUserCookie(usuario);
                if(usuario.Cargo == Dto.CargoEnum.Administrador)
                {
                    return RedirectToAction("Index", "Administrador");
                }
                else
                {
                    return RedirectToAction("Index", "Recepcionista");
                }
            }
        }

        private async Task SetUserCookie(Usuario usuario)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, usuario!.Nombre!),
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                new Claim(ClaimTypes.Role, usuario.Cargo!.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
