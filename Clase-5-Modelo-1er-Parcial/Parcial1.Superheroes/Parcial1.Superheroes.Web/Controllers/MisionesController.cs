using Microsoft.AspNetCore.Mvc;
using Parcial1.Superheroes.Entidades;
using Parcial1.Superheroes.Logica;

namespace Parcial1.Superheroes.Web.Controllers
{
    public class MisionesController : Controller
    {
        //MisionesLogica
        private readonly IMisionesLogica _misionesLogica;

        public MisionesController(IMisionesLogica misionesLogica)
        {
            _misionesLogica = misionesLogica;
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Mision mision)
        {
            if (!ModelState.IsValid)
            {
                return View(mision);
            }

            _misionesLogica.RegistrarMision(mision);
            TempData["Mensaje"] = $"Misión registrada con éxito. {mision.NombreSuperheroe} (Indice de Eficiencia: {mision.IndiceEficiencia})";

            //redirigir a resultados
            return RedirectToAction("Resultados");
        }

        [HttpGet]
        public IActionResult Resultados()
        {
            // Obtener la lista de misiones
            List<Mision> misiones = _misionesLogica.ObtenerMisiones();
            // Pasar la lista a la vista
            return View(misiones);
        }
    }
}
