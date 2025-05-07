using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Clase4.POO.Logica;

namespace Clase4.POO.Web.Controllers
{
    public class AnimalController : Controller
    {
        private readonly IAnimalServicio _animalServicio;

        public AnimalController(IAnimalServicio animalServicio)
        {
            _animalServicio= animalServicio;
        }

        [HttpGet]
        public IActionResult ObtenerAnimales()
        {
            var animales = _animalServicio.ObtenerAnimales();
            return View(animales);
        }

        [HttpGet]
        public IActionResult AgregarAnimal()
        {
            return View(_animalServicio.ObtenerTiposDeAnimales());
        }

        [HttpPost]
        public IActionResult Agregar(string tipo,string nombre)
        {
            try
            {
                _animalServicio.AgregarAnimal(tipo, nombre);
                return Redirect("ObtenerAnimales");
            }
            catch (TipoDeAnimalInvalidoException ex)
            {
                return NotFound();
            }
        }

    }
}
