using Clase3.MVC.Entidades;

namespace Clase3.MVC.Servicio.Interfaces;

public interface IPokemonService
{
    List<Pokemon> ObtenerPokemons();
    void AgregarPokemon(Pokemon pokemon);
}
