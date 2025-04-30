using Clase3.MVC.Entidades;

namespace Clase3.MVC.Servicio
{

    public interface IRegaloServicio
    {
        List<Regalo> ObtenerRegalos();
        void AgregarRegalo(Regalo regalo);
    }
    public class RegaloServicio : IRegaloServicio
    {
        private static List<Regalo> _regalos { get; set; }

        public RegaloServicio()
        {
            if (_regalos == null)
            {
                _regalos = new List<Regalo>();
                _regalos.Add(new Regalo { Descripcion = "Flores", Precio = 100, Imagen = "/imagenes/regalos/flores.jpg" });
                _regalos.Add(new Regalo { Descripcion = "Chocolates", Precio = 200, Imagen = "/imagenes/regalos/Chocolates.jpg" });
                _regalos.Add(new Regalo { Descripcion = "Peluche", Precio = 300, Imagen = "/imagenes/regalos/Peluche.jpg" });
            }
            
        }
        public List<Regalo> ObtenerRegalos()
        {
            return _regalos;
        }
        public void AgregarRegalo(Regalo regalo)
        {
            _regalos.Add(regalo);
        }
    }
}
