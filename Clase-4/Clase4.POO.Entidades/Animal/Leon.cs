using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase4.POO.Entidades.Animal
{
    public class Leon : Animal
    {
        public Leon(string nombre) : base("Leon")
        {
            _nombre = nombre;

        }

        public override string HacerSonido()
        {
            return "Rugido";
        }
    }
}
