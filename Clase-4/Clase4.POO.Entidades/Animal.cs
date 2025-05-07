using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
    public abstract class Animal
    {
        public abstract string Tipo { get; }
        public abstract string HacerSonido();
    }
}
