namespace Clase2.Entidad
{
    public class Equipo
    {
        public Equipo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int id { get; set; }
        public string nombre { get; set; }
    }
}