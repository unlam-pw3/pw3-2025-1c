namespace Clase4.POO.Entidades
{
    public class Gato : IAnimales
    {
        public string Nombre { get; set; }
        public string HacerRuido()
        {
            return "Miau";
        }
    }

}
