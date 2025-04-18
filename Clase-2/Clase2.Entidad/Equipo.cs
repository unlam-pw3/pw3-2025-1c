namespace Clase2.Logica
{
    public class Equipo
    {
        public Equipo(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}