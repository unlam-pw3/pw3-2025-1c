using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public class Vaca : Animal
    {

        public Vaca(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override string HacerSonido()
        {
            return "Muuu";
        }

    }
}
