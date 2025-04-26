using Clase3.MVC.Entidades;
using Clase3.MVC.Servicio.Interfaces;

namespace Clase3.MVC.Servicio.Servicios
{
    public class PokemonServicio : IPokemonService
    {
        private static List<Pokemon> pokemons { get; set; }

        public PokemonServicio()
        {
            if (pokemons == null)
            {
                pokemons = new List<Pokemon>();
                pokemons.Add(new Pokemon { Id = 1, Nombre = "Bulbasaur", Tipo = "Planta - Veneno", Imagen = "/imagenes/bulbasaur.png" });
                pokemons.Add(new Pokemon { Id = 2, Nombre = "Ivysaur", Tipo = "Planta - Veneno", Imagen = "/imagenes/ivysaur.png" });
                pokemons.Add(new Pokemon { Id = 3, Nombre = "Venusaur", Tipo = "Planta - Veneno", Imagen = "/imagenes/venusaur.png" });
            }
        }
        public void AgregarPokemon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

        public List<Pokemon> ObtenerPokemons()
        {
            return pokemons;
        }
    }
}
