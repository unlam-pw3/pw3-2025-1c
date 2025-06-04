namespace Clase4.POO.Entidades
{
    public class Vaca : IAnimales
    {
        public string Nombre { get; set; }
        public string HacerRuido()
        {
            return "Muu";
        }
    }
}
