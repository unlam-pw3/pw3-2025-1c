using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Clase4.POO.Web.Controllers
{
    public class AnimalesController(IAnimalesLogica _animalesLogica) : Controller
    {
        public IActionResult Listar()
        {
            var animales = _animalesLogica.ObtenerAnimales();
            return View(animales);
        }
        [HttpGet]
        public IActionResult Agregar()
        {
            var interfaceType = typeof(IAnimales);

            var animalTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => interfaceType.IsAssignableFrom(t) && t.IsClass && !t.IsAbstract)
                .Select(t => t.Name)
                .ToList();
            ViewData["Animales"] = animalTypes;

            return View();
        }

        [HttpPost]
        public IActionResult Agregar(IAnimales animal)
        {
            _animalesLogica.AgregarAnimal(animal);
            return RedirectToAction("Listar");
        }

    }
}
