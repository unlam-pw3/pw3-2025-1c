using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Entidades.Animal
{
    public abstract class Animal
    {
        protected readonly string _tipo;
        public string _nombre;
        protected Animal(string tipo)
        {
            _tipo = tipo;
        }
        public abstract string HacerSonido();
        public string ObtenerTipo()
        {
            return _tipo;
        }
    }
}
