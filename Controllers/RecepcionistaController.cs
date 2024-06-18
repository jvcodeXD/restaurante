using Microsoft.AspNetCore.Mvc;

namespace Restaurante.Controllers
{
    public class RecepcionistaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
