using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public class Gallina : Animal
    {
        public override string Tipo => "Gallina";

        public override string HacerSonido() => "Cloc cloc";
    }
}
