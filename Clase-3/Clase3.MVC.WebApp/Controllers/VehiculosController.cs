using Clase3.MVC.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers
{
    public class VehiculosController : Controller
    {

        private IVehiculosServicio _vehiculosServicio;

        public VehiculosController(IVehiculosServicio vehiculosServicio)
        {
           _vehiculosServicio = vehiculosServicio;
        }

        [HttpGet]
        public IActionResult Editar([FromQuery] int id)
        {
            
            return View(this._vehiculosServicio.obtenerVehiculoPorId(id));
        }

        public IActionResult Agregar()
        {
            return View();
        }


    }
}
