using Clase3.Servicio;
using Clase3.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Trea_Clase_3.Controllers
{
    public class AutomovilController : Controller
    {
        private readonly IAutomovilServicio _servicio;
        public AutomovilController(IAutomovilServicio servicio)
        {
            _servicio = servicio;
        }
        public IActionResult Index()
        {
            var lista = _servicio.ObtenerTodos();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Automovil auto)
        {
            if (ModelState.IsValid)
            {
                _servicio.Agregar(auto);
                return RedirectToAction("Index");
            }
            return View(auto);
        }
    }
}
