    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public class AnimalGallina : AbstractAnimal
    {
        private string NombreAnimal;
        public override string Nombre { 
            get => NombreAnimal; 
            set => NombreAnimal = value; 
        
        }

        public override string HacerSonido()
        {
            return "Cloc cloc";
        }
    }
}
