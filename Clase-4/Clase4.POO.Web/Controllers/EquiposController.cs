using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.Web.Controllers
{
    public class EquiposController : Controller
    {
        private readonly IEquiposLogica _equiposLogica;
        public EquiposController(IEquiposLogica equiposLogica)
        {
            _equiposLogica = equiposLogica;
        }
        // GET: Equipos
        public IActionResult Listar()
        {
            var equipos = _equiposLogica.ObtenerEquipos();
            return View(equipos);
        }

        [HttpGet]
        public IActionResult AgregarEquipoFutbol()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarEquipoFutbol(EquipoFutbol equipo)
        {
            if (ModelState.IsValid)
            {
                _equiposLogica.AgregarEquipo(equipo);
                return RedirectToAction("Listar");
            }
            return View(equipo);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
