using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades.Animal
{
    public class Gallina : Animal
    {
        public Gallina(string nombre) : base("Gallina")
        {
            _nombre = nombre;
        }

        public override string HacerSonido()
        {
            return "Cloc cloc";
        }
    }
}
