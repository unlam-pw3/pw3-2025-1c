namespace Clase4.POO.Entidades
{
    public class Gallina : IAnimales
    {
        public string Nombre { get; set; }
        public string HacerRuido()
        {
            return "Cloc Cloc";
        }
    }
}
