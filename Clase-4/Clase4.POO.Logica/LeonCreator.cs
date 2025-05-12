using Clase4.POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Logica
{
    public class LeonCreator : IAnimalCreator
    {
        public string Tipo => "león";
        public Animal Crear(string nombre, int edad) => new Leon(nombre, edad);
    }
}
