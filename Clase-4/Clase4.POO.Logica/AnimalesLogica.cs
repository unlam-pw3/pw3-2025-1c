using Clase4.POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Logica
{
    public interface IAnimalesLogica
    {
        void AgregarAnimal(Animal animal);
        List<Animal> ObtenerAnimales();
    }

    public class AnimalesLogica : IAnimalesLogica
    {
        private List<Animal> Animales { get; set; }

        public AnimalesLogica()
        {
            Animales = new List<Animal>();

            // Agregamos equipos de ejemplo
            Animales.Add(new Perro("Jorge",3));
            Animales.Add(new Gato("Michi",2));
            Animales.Add(new Vaca("Lola",7));
            Animales.Add(new Gallina("Graciela",1));
            Animales.Add(new Leon("Pedrito",12));
        }
        public void AgregarAnimal(Animal animal)
        {
            Animales.Add(animal);
        }

        public List<Animal> ObtenerAnimales()
        {
            return Animales;
        }



    }
}
