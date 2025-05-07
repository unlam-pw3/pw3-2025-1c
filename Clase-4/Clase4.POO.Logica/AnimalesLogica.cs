using Clase4.POO.Entidades;

namespace Clase4.POO.Logica;

    public class AnimalesLogica
    {
        private List<Animal> animales { get; set; }
        public AnimalesLogica()
        {
            animales = new List<Animal>();

            animales.Add(new Perro());
            animales.Add(new Gato());
            animales.Add(new Gallina());
            animales.Add(new Vaca());
            animales.Add(new Leon());
        }

        public void AgregarAnimal(Animal animal)
        {
            animales.Add(animal);
        }

        public List<Animal> ListarAnimales() => animales;
    }

