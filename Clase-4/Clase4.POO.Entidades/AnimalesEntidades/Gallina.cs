using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades.AnimalesEntidades
{
    public class Gallina : Animal
    {
        public Gallina() { 
        }
        public Gallina(string nombre, string tipo) : base(nombre, tipo)
        {
        }

        public override string HacerSonido()
        {
            return "Cloc cloc";
        }
    }
    
}
