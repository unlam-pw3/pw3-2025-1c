using Microsoft.AspNetCore.Mvc;
using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Clase4.POO.Web.Models;

namespace Clase4.POO.Web.Controllers
{
    public class AnimalesController : Controller
    {
        private readonly AnimalesLogica _animalesLogica;

        public AnimalesController(AnimalesLogica animalesLogica)
        {
            _animalesLogica = animalesLogica;
        }

        public IActionResult Index()
        {
            var animales = _animalesLogica.ListarAnimales();
            return View(animales);
        }

        [HttpGet]
        public IActionResult AgregarAnimal() 
        {
            var viewModel = new AnimalViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AgregarAnimal(AnimalViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Animal nuevoAnimal = null;
                switch (viewModel.Tipo)
                {
                    case "Perro":
                        nuevoAnimal = new Perro();
                        break;
                    case "Gato":
                        nuevoAnimal = new Gato();
                        break;
                    case "Vaca":
                        nuevoAnimal = new Vaca();
                        break;
                    case "Gallina":
                        nuevoAnimal = new Gallina();
                        break;
                    case "Leon":
                        nuevoAnimal = new Leon();
                        break;
                    default:
                        ModelState.AddModelError("Tipo", "Tipo de animal no válido");
                        return View(viewModel);
                }

                _animalesLogica.AgregarAnimal(nuevoAnimal);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

    }
}
