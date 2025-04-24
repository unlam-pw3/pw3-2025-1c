using Clase3.MVC.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers
{
    public class RegalosController : Controller
    {
        private IRegaloServicio _regaloServicio;

        public RegalosController(IRegaloServicio regaloServicio)
        {
            _regaloServicio = regaloServicio;
        }

        public IActionResult Index()
        {
            return View(_regaloServicio.ObtenerRegalos());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agregar(string descripcion, decimal precio)
        {

            _regaloServicio.AgregarRegalo(new Entidades.Regalo { Descripcion = descripcion, Precio = precio });
            return RedirectToAction("Index");

        }
    }
}
