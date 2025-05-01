using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase4.POO.Entidades.Animal
{
    public class Perro : Animal
    {
        public Perro(string nombre) : base("Perro")
        {
            _nombre = nombre;

        }

        public override string HacerSonido()
        {
            return "Guau";
        }
    }
}
