using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase3.MVC.Entidades;

namespace Clase3.MVC.Servicio
{
    public interface IVehiculosServicio
    {
        List<Regalo> ObtenerRegalos();
        void AgregarRegalo(Regalo regalo);

        List<Vehiculo> ObtenerVehiculos();

        void AgregarVehiculo(Vehiculo vehiculo);

        int EliminarVehiculo(int id);

        List<Vehiculo> BuscarVehiculo(String vehiculo);
    }
    public class VehiculoServicio : IVehiculosServicio
    {
        private static List<Regalo> _regalos { get; set; }
        private static List<Vehiculo> _vehiculos { get; set; }
        public VehiculoServicio()
        {
            if(_vehiculos == null)
            {
                _vehiculos = new List<Vehiculo>();
                _vehiculos.Add(new Vehiculo { Marca = "Toyota", Modelo = "Corolla", Precio = 20000, Kilometros = 15000 });
                _vehiculos.Add(new Vehiculo { Marca = "Ford", Modelo = "Focus", Precio = 18000, Kilometros = 20000 });
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

        public List<Vehiculo> ObtenerVehiculos()
        {
            return _vehiculos;
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            _vehiculos.Add(vehiculo);
        }

        public List<Vehiculo> BuscarVehiculo(string buscar)
        {
            List<Vehiculo> encontrado = new List<Vehiculo>();
            foreach(var Vehiculo in _vehiculos)
            {

                if (Vehiculo.Marca.StartsWith(buscar, StringComparison.OrdinalIgnoreCase) ||
                    Vehiculo.Modelo.StartsWith(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado.Add(Vehiculo);
                }


            }

            return encontrado;
        }

        public int EliminarVehiculo(int id)
        {
           return _vehiculos.RemoveAll(v => v.Id == id);
        }
    }
}
