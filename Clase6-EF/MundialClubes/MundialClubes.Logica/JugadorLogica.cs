using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundialClubes.Entidades.EF;

namespace MundialClubes.Logica
{
    public interface IJugadorLogica
    {
        List<JugadorEstrella> ObtenerTodosLosJugadores();
        void AgregarJugador(JugadorEstrella jugador);
        JugadorEstrella ObtenerJugadorPorId(int idJugador);
        void EliminarJugador(int idJugador);
        void Actualizar(JugadorEstrella jugador);
    }
    public class JugadorLogica : IJugadorLogica
    {
        private readonly MundialClubesContext _context;
        public JugadorLogica(MundialClubesContext context)
        {
            _context = context;
        }
        public void Actualizar(JugadorEstrella jugador)
        {
            var jugadorActualizar = _context.JugadorEstrella.Find(jugador.IdJugadorEstrella);

            if (jugadorActualizar != null)
            {
                jugadorActualizar.Descripcion = jugador.Descripcion;
                jugadorActualizar.Edad = jugador.Edad;  
                jugadorActualizar.FotoUrl = jugador.FotoUrl;
                jugadorActualizar.Nombre = jugador.Nombre;

                _context.SaveChanges();

            }
        }

        public void AgregarJugador(JugadorEstrella jugador)
        {
            _context.JugadorEstrella.Add(jugador);
            _context.SaveChanges();
        }

        public void EliminarJugador(int idJugador)
        {
            var jugador = _context.JugadorEstrella.Find(idJugador);

            if(jugador != null)
            {
                _context.JugadorEstrella.Remove(jugador);
                _context.SaveChanges();
            }

      
        }

        public JugadorEstrella ObtenerJugadorPorId(int idJugador)
        {
            return _context.JugadorEstrella.Find(idJugador);
        }

        public List<JugadorEstrella> ObtenerTodosLosJugadores()
        {
            return _context.JugadorEstrella.ToList();
        }
    }
}
