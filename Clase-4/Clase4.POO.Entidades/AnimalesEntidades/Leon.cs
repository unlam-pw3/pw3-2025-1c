using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades.AnimalesEntidades
{
    public class Leon : Animal
    {
        public Leon() {
        }
        public Leon(string nombre, string tipo) : base(nombre, tipo)
        {
        }
        public override string HacerSonido()
        {
            return "Rugido";
        }
    }

}
