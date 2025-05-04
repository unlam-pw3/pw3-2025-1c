using Clase4.POO.Entidades.AnimalesEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Logica;

public interface IAnimal
{
    List<Animal> ObtenerAnimales();
    void AgregarAnimal(Animal animal);
    void EliminarAnimal(Animal animal);
}

public class AnimalesLogica : IAnimal
{
    private List<Animal> animales;
    public AnimalesLogica()
    {
        animales = new List<Animal>();
        animales.Add(new Perro("Firulais", "Perro"));
        animales.Add(new Gato("Michi", "Gato"));
        animales.Add(new Gallina("Clara", "Gallina"));
        animales.Add(new Leon("Simba", "Leon"));
        animales.Add(new Vaca("Lola", "Vaca"));

    }
    public List<Animal> ObtenerAnimales()
    {
        return animales;
    }
    public void AgregarAnimal(Animal animal)
    {
        animales.Add(animal);
    }
    public void EliminarAnimal(Animal animal)
    {

        foreach (Animal AnimalAeliminar in animales)
        {
            if (AnimalAeliminar.Nombre.Equals(animal.Nombre) && AnimalAeliminar.Tipo.Equals(animal.Tipo))
            {
                animales.Remove(AnimalAeliminar);
                break;
            }
        }
    }
}
