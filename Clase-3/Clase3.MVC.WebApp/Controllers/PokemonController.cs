using Clase3.MVC.Entidades;
using Clase3.MVC.Servicio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }
        public IActionResult Index()
        {
            return View(_pokemonService.ObtenerPokemons());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(Pokemon pokemon, IFormFile imagen)
        {
            if (imagen != null && imagen.Length > 0)
            {
                var rutaCarpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imagenes");

                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                var nombreArchivo = $"{pokemon.Nombre}{Path.GetExtension(imagen.FileName)}";
                var rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

                using (var stream = new FileStream(rutaCompleta, FileMode.Create))
                {
                    await imagen.CopyToAsync(stream);
                }

                pokemon.Imagen = $"/imagenes/{nombreArchivo}";
            }
            _pokemonService.AgregarPokemon(pokemon);

            return RedirectToAction("Index");
        }
    }
}
