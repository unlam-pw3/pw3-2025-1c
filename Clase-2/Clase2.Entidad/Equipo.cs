using System;
namespace Clase2.Entidad
{
    public class Equipo
    {
        private static int contadorId = 0;
        public string nombre {  get; set; }
        public string paisOrigen {  get; set; }

        public int id { get; set; }

        public Equipo(bool generarId)
        {
            if (generarId)
            {
                contadorId++;
                id = contadorId;
            }
        }

        public Equipo() { }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Equipo other = (Equipo)obj;
            return this.id == other.id;
        }




    }

}
