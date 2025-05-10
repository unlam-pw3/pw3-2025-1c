using Clase2.Entidad;

namespace Clase2.Logica
{

    public interface IEquipoServicio
    {
        void AgregarEquipo(Equipo equipo);
        List<Equipo> ObtenerEquipos();

        void EliminarEquipo(string nombre);
    }

    public class EquipoServicio : IEquipoServicio
    {
        private List<Equipo> _equipos;
        
        public EquipoServicio()
        {
            _equipos = new List<Equipo>();
        }
        public void AgregarEquipo(Equipo equipo)
        {
            _equipos.Add(equipo);
        }
        public List<Equipo> ObtenerEquipos()
        {
            return _equipos;
        }

        public void EliminarEquipo(string nombre)
        {
            var equipo = _equipos.FirstOrDefault(e => e.nombre == nombre);
            if (equipo != null)
            {
                _equipos.Remove(equipo);
            }
        }

    }
}
