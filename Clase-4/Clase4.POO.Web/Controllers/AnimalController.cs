using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.Web.Controllers
{
    public class AnimalController : Controller
    {

        private readonly IAnimalesLogica _animalesLogica;

        public AnimalController(IAnimalesLogica animalesLogica)
        {
            _animalesLogica = animalesLogica;
        }

        public IActionResult ListarAnimales()
        {
            var animales = _animalesLogica.ObtenerAnimals();
            return View(animales);
        }


        [HttpGet]
        public IActionResult NuevoAnimal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarAnimal(string nombre, string tipoAnimal) { 
        
            AbstractAnimal abstractAnimal;


            switch (tipoAnimal)
            {
                case "Gato":
                    abstractAnimal = new AnimalGato{ Nombre = nombre};
                    break;
                case "Leon":
                    abstractAnimal = new AnimalLeon { Nombre = nombre };
                    break;
                case "Vaca":
                    abstractAnimal = new AnimalVaca { Nombre = nombre };
                    break;
                case "Gallina":
                    abstractAnimal = new AnimalGallina { Nombre = nombre };
                    break;
                case "Perro":
                    abstractAnimal = new AnimalPerro { Nombre = nombre };
                    break;
                default:
                    return BadRequest("Tipo de animal no válido");
            }
            _animalesLogica.AgregarAnimal(abstractAnimal);
            return RedirectToAction("ListarAnimales");
         

      
        }



    }
}
