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
       
        List<Vehiculo> ObtenerVehiculos();

        void AgregarVehiculo(Vehiculo vehiculo);

        int EliminarVehiculo(int id);

        Vehiculo obtenerVehiculoPorId(int id);

        void editarVehiculo(Vehiculo vehiculo);
        List<Vehiculo> BuscarVehiculo(String vehiculo);
    }
    public class VehiculoServicio : IVehiculosServicio
    {
      
        private static List<Vehiculo> _vehiculos { get; set; }
        public VehiculoServicio()
        {
            if(_vehiculos == null)
            {
                _vehiculos = new List<Vehiculo>();

                _vehiculos.Add(new Vehiculo { Marca = "Toyota", Modelo = "Corolla", Precio = 20000, Kilometros = 15000 });
                _vehiculos.Add(new Vehiculo { Marca = "Ford", Modelo = "Focus", Precio = 18000, Kilometros = 20000});
                _vehiculos.Add(new Vehiculo { Marca = "Chevrolet", Modelo = "Cruze", Precio = 19000, Kilometros = 22000 });
                _vehiculos.Add(new Vehiculo { Marca = "Volkswagen", Modelo = "Golf", Precio = 21000, Kilometros = 17000 });
                _vehiculos.Add(new Vehiculo { Marca = "Honda", Modelo = "Civic", Precio = 23000, Kilometros = 13000 });
                _vehiculos.Add(new Vehiculo { Marca = "Nissan", Modelo = "Sentra", Precio = 17500, Kilometros = 25000 });
                _vehiculos.Add(new Vehiculo { Marca = "Hyundai", Modelo = "Elantra", Precio = 18500, Kilometros = 1600 });
                _vehiculos.Add(new Vehiculo { Marca = "Kia", Modelo = "Cerato", Precio = 19500, Kilometros = 18000 });
                _vehiculos.Add(new Vehiculo { Marca = "Peugeot", Modelo = "208", Precio = 16500, Kilometros = 14000 });
                _vehiculos.Add(new Vehiculo { Marca = "Renault", Modelo = "Fluence", Precio = 17000, Kilometros = 21000  });

            }

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

        public Vehiculo obtenerVehiculoPorId(int id)
        {
 

            foreach(var vehiculoOb in _vehiculos)
            {
                if(vehiculoOb.Id == id)
                {
                    return vehiculoOb;
                }
            }

            return null;
        }

        public void editarVehiculo(Vehiculo vehiculo)
        {
            foreach (var vehiculoOb in _vehiculos)
            {
                if (vehiculoOb.Id == vehiculo.Id)
                {
                    vehiculoOb.Modelo = vehiculo.Modelo;
                    vehiculoOb.Marca = vehiculo.Marca;
                    vehiculoOb.Precio = vehiculo.Precio;
                    vehiculoOb.Kilometros = vehiculo.Kilometros;
                    break;
                }
            }
        }
    }
}
