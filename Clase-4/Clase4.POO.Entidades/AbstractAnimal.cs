using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades
{
   public abstract class AbstractAnimal
    {

        public abstract string HacerSonido(); 
        public abstract string Nombre { get; set; }

    }
}
