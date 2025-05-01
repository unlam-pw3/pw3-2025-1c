using Clase3.MVC.Entidades;

namespace Clase3.MVC.Servicio
{

    public interface IAutomovilServicio
    {
        List<Automovil> ObtenerAutomoviles();
        void AgregarAutomovil(Automovil automovil);
    }

    public class AutomovilServicio : IAutomovilServicio
    {
        public static List<Automovil> _automoviles { get; set; }
       
        public AutomovilServicio()
        {
            if (_automoviles == null)
            {
                _automoviles = new List<Automovil>();
                _automoviles.Add(new Automovil { Marca = "Volkswagen", Modelo = "Golf", Color = "Rojo", Foto = "/imagenes/automoviles/VolkswagenGolf.jpg" });
                _automoviles.Add(new Automovil { Marca = "Ford", Modelo = "Focus", Color = "Azul", Foto = "/imagenes/automoviles/FordFocus.jpg" });
                _automoviles.Add(new Automovil { Marca = "Honda", Modelo = "HRV", Color = "Negro", Foto = "/imagenes/automoviles/HondaHRV.jpg" });
                _automoviles.Add(new Automovil { Marca = "Toyota", Modelo = "Corolla", Color = "Blanco", Foto = "/imagenes/automoviles/ToyotaCorolla.jpg" });
            }
        }
        public List<Automovil> ObtenerAutomoviles()
        {
            return _automoviles;
        }
        public void AgregarAutomovil(Automovil automovil)
        {
            _automoviles.Add(automovil);
        }
    }
}