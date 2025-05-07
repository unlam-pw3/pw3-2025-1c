using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public class Vaca : Animal
    {
        public override string Tipo => "Vaca";
        public override string HacerSonido() => "Muuu";
    }
}
