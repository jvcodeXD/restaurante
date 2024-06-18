using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurante.Contexto;

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
    }
}
