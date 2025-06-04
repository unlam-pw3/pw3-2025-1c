using Clase4.POO.Entidades;

namespace Clase4.POO.Logica;

public class AnimalesLogica : IAnimalesLogica
{
    private List<IAnimales> Animales;

    public AnimalesLogica()
    {
        Animales = new List<IAnimales>();

        Animales.Add(new Gallina { Nombre = "Gallina" });
        Animales.Add(new Gato { Nombre = "Gato" });
        Animales.Add(new Leon { Nombre = "Leon" });
        Animales.Add(new Perro { Nombre = "Perro" });
        Animales.Add(new Vaca { Nombre = "Vaca" });
    }

    public void AgregarAnimal(IAnimales animal)
    {
        Animales.Add(animal);
    }

    public List<IAnimales> ObtenerAnimales()
    {
        return Animales;
    }
}
