using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase4.POO.Entidades;
namespace Clase4.POO.Logica
{
    public interface IAnimalesLogica
    {
        void AgregarAnimal(AbstractAnimal animal);
        List<AbstractAnimal> ObtenerAnimals();
    }
    public class AnimalLogica : IAnimalesLogica
    {
        private List<AbstractAnimal> Animals { get; set; }
        public AnimalLogica(){
            
            Animals = new List<AbstractAnimal>();

            Animals.Add(new AnimalGato { Nombre = "Chimuelo" });
            Animals.Add(new AnimalVaca { Nombre = "Lola" });
            Animals.Add(new AnimalLeon { Nombre = "Alex" });
            Animals.Add(new AnimalPerro { Nombre = "Seymour Diera" });
            Animals.Add(new AnimalGallina { Nombre = "Turuleca" });
           
        }


        public void AgregarAnimal(AbstractAnimal animal)
        {

            if(animal == null)
            {
                return;
            }
            Animals.Add(animal);
        }

        public List<AbstractAnimal> ObtenerAnimals()
        {
            return Animals;
        }
    }
}
