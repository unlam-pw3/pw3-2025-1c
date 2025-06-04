using Microsoft.EntityFrameworkCore;
using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Logica.Repositories;

public class JugadorEstrellaRepository(MundialDeClubesContext _context) : IJugadorEstrellaRepository
{
    public JugadorEstrella GetJugadorEstrellaById(int id)
    {
        return _context.JugadorEstrellas.FirstOrDefault(j => j.IdJugadorEstrella == id);
    }

    public List<JugadorEstrella> GetAllJugadoresEstrellas()
    {
        return _context.JugadorEstrellas.Include(j => j.IdClubNavigation).ToList();
    }

    public void AddJugadorEstrella(JugadorEstrella jugadorEstrella)
    {
        _context.JugadorEstrellas.Add(jugadorEstrella);
        _context.SaveChanges();
    }

    public void UpdateJugadorEstrella(JugadorEstrella jugadorEstrella)
    {
        _context.JugadorEstrellas.Update(jugadorEstrella);
        _context.SaveChanges();
    }

    public void DeleteJugadorEstrella(int id)
    {
        var jugador = _context.JugadorEstrellas.Find(id);
        if (jugador != null)
        {
            _context.JugadorEstrellas.Remove(jugador);
            _context.SaveChanges();
        }
    }
}
