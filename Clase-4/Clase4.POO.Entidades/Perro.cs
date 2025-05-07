using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public class Perro : Animal
    {
        public override string Tipo => "Perro";
        public override string HacerSonido() => "Guau";

    }
}
