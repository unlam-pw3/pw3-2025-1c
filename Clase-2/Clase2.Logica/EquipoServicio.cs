using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase2.API.Controllers;

namespace Clase2.Logica
{
    public interface IEquipoServicio
    {
        Equipo AgregarEquipo(EquipoDTO equipo);
        List<Equipo> ObtenerEquipos();
    }

    public class EquipoServicio : IEquipoServicio
    {
        List<Equipo> _equipos;

        public EquipoServicio()
        {
            _equipos = new List<Equipo>();
        }

        public Equipo AgregarEquipo(EquipoDTO equipoDTO)
        {
            int id = (_equipos == null || _equipos.Count == 0) ? 1 : _equipos.Count;
            Equipo equipo = new Equipo(id, equipoDTO.nombre);
            _equipos.Add(equipo);
            return equipo;
        }

        public List<Equipo> ObtenerEquipos()
        {
                return _equipos;
        }
    }
}
