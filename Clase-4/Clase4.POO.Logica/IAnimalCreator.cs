using Clase4.POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Logica
{
    public interface IAnimalCreator
    {
        string Tipo { get; }
        Animal Crear(string nombre, int edad);
    }
}
