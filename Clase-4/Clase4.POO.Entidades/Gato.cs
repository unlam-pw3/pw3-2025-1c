using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public class Gato : Animal
    {
        public override string Tipo => "Gato";
        public override string HacerSonido() => "Miau";
    }
}
