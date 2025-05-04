using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades.AnimalesEntidades
{
    public class Perro : Animal
    {
        public Perro()
        {
        }
        public Perro(string nombre, string tipo) : base(nombre, tipo)
        {
        }

        public override string HacerSonido()
        {
            return "Guau";
        }

    }
}
