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
        public IActionResult Index()
        {
            return View();
        }
    }
}
