using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public class Leon : Animal
    {
        public override string Tipo => "Leon";
        public override string HacerSonido() => "Rawr";
    }
}
