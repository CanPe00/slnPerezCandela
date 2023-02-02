using Microsoft.AspNetCore.Mvc;
using System;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Saludo = "Bienvenido al sistema web de Mis Recetas";
            ViewBag.Fecha = DateTime.Now.Date.ToShortDateString();
            return View();
        }
    }
}
