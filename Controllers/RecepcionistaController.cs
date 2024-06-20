using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Restaurante.Controllers
{
    [Authorize(Roles = "Recepcionista")]
    public class RecepcionistaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
