using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clase4.POO.Entidades.AnimalesEntidades;

public abstract class Animal
{
    public string Nombre { get; set; }
    public string Tipo { get; set; }

    public Animal(string nombre, string tipo)
    {
        Nombre = nombre;
        Tipo = tipo;
    }

    public Animal() { }

    public string Desplazarse() {
        return $"{Nombre} se está desplazanado";
    }

    public abstract string HacerSonido();

}
