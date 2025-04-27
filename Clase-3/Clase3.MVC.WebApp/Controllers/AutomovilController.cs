using Clase3.MVC.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers

{
    public class  AutomovilController : Controller
    {
        private IAutomovilServicio _automovilServicio;

        public AutomovilController(IAutomovilServicio automovilServicio)
        {
            _automovilServicio = automovilServicio;
        }

        public IActionResult Index()
        {
            return View(_automovilServicio.ObtenerAutomoviles());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(string marca, string modelo, string color)
        {
            _automovilServicio.AgregarAutomovil(new Entidades.Automovil { Marca = marca, Modelo = modelo, Color = color });
            return RedirectToAction("Index");
        }

    }
}