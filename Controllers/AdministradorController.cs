﻿using Microsoft.AspNetCore.Mvc;

namespace Restaurante.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
