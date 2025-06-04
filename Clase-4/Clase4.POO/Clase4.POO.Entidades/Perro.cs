namespace Clase4.POO.Entidades
{
    public class Perro : IAnimales
    {
        public string Nombre { get; set; }
        public string HacerRuido()
        {
            return "Guau";
        }
    }
}
