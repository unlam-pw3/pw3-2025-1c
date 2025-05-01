using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Clase4.POO.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Clase4.POO.Web.Controllers
{
    public class AnimalesController : Controller
    {
        private readonly IAnimalesLogica _animalesLogica;
        private readonly AnimalFactory _factory;

        public AnimalesController(IAnimalesLogica animalesLogica, AnimalFactory factory)
        {
            _animalesLogica = animalesLogica;
            _factory = factory;
        }

        // GET: Animales
        public IActionResult Listar()
        {
            var animales = _animalesLogica.ObtenerAnimales();
            return View(animales);
        }

        [HttpGet]
        public IActionResult AgregarAnimal()
        {
            var model = new AnimalViewModel
            {
                TiposAnimales = _factory.ObtenerTiposAnimales()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult AgregarAnimal(AnimalViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.TiposAnimales = _factory.ObtenerTiposAnimales();
                return View(model);
            }
            try
            {
                var animal = _factory.CrearAnimal(model.TipoAnimal, model.Nombre, model.Edad);
                animal.Nombre = model.Nombre;

                _animalesLogica.AgregarAnimal(animal);
                return RedirectToAction(nameof(Listar));
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError(nameof(model.TipoAnimal), ex.Message);
                model.TiposAnimales = _factory.ObtenerTiposAnimales();
                return View(model);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
