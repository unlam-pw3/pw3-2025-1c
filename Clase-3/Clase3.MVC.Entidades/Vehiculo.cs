using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.MVC.Entidades
{
    public class Vehiculo
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Precio { get; set; }

        public int Kilometros { get; set; }

        private static int IdCont = 0;

        public int Id { get; private set; }


        public Vehiculo()
        {
            IdCont++;

            Id = IdCont;
        }




    }
}
