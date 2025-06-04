namespace Clase4.POO.Entidades
{
    public class Leon : IAnimales
    {
        public string Nombre { get; set; }
        public string HacerRuido()
        {
            return "Rugido";
        }
    }
}
