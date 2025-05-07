using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase4.POO.Entidades.Animal;
using Clase4.POO.Entidades;

namespace Clase4.POO.Logica
{

    public interface IAnimalServicio
    {
        public void AgregarAnimal(string tipo, string nombre);
        public List<Animal> ObtenerAnimales();
        public List<string> ObtenerTiposDeAnimales();
    }

    public class AnimalServicio : IAnimalServicio
    {

        private List<Animal> _animales = new List<Animal>();
        private List<string> _tiposDeAnimales= new List<string>();

        public AnimalServicio()
        {
            CargarAnimales();
            CargarTipoDeAnimales();
        }

        private void CargarAnimales()
        {
            _animales.Add(new Perro("perro"));
            _animales.Add(new Gato("gato"));
            _animales.Add(new Vaca("vaca"));
            _animales.Add(new Gallina("gallina"));
            _animales.Add(new Leon("leon"));
        }
        private void CargarTipoDeAnimales()
        {
            for (int i = 0; i < _animales.Count; i++)
            {
                _tiposDeAnimales.Add(_animales[i].ObtenerTipo());
            }
        }

        public void AgregarAnimal(string tipo,string nombre)
        {
            if (!_tiposDeAnimales.Contains(tipo))
            {
                throw new TipoDeAnimalInvalidoException();
            }
            var animal = ObtenerInstanciaAnimal(tipo,nombre);

            _animales.Add(animal);
        }

        private Animal ObtenerInstanciaAnimal(string tipo,string nombre)
        
        {
            switch (tipo.ToLower())
            {
                case "perro":
                    return new Perro(nombre);
                case "gato":
                    return new Gato(nombre);
                case "vaca":
                    return new Vaca(nombre);
                case "gallina":
                    return new Gallina(nombre);
                case "leon":
                    return new Leon(nombre);
                default:
                    throw new ArgumentException("Tipo de animal no válido");
            }
        }

        public List<Animal> ObtenerAnimales()
        {
            return _animales;
        }

        public List<string> ObtenerTiposDeAnimales()
        {
            return _tiposDeAnimales;
        }
    }
}
