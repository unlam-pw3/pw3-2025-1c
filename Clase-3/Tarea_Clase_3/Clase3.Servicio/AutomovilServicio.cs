using Clase3.Entidades;

namespace Clase3.Servicio
{
    public class AutomovilServicio : IAutomovilServicio
    {
        private static List<Automovil> _autos = new List<Automovil>();

        public List<Automovil> ObtenerTodos()
        {
            return _autos;
        }

        public void Agregar(Automovil auto)
        {
            _autos.Add(auto);
        }
    }
}
