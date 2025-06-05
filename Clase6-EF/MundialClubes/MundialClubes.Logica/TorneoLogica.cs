using Microsoft.EntityFrameworkCore;
using MundialClubes.Entidades.EF;

namespace MundialClubes.Logica;

public interface ITorneoLogica
{
    List<Torneo> ObtenerTodosLosTorneos();
    void CrearTorneo(Torneo torneo);
    Torneo? ObtenerTorneoPorId(int id);
    void EliminarTorneo(int idTorneo);
    void AgregarClubATorneo(int idTorneo, int idClub);
    void EliminarClubDeTorneo(int idTorneo, int idClub);

}

public class TorneoLogica : ITorneoLogica
{
    private readonly MundialClubesContext _context;
    public TorneoLogica(MundialClubesContext context)
    {
        _context = context;
    }

    public List<Torneo> ObtenerTodosLosTorneos()
    {
        return _context.Torneos.ToList();
    }

    public void CrearTorneo(Torneo torneo)
    {
        _context.Torneos.Add(torneo);
        _context.SaveChanges();
    }

    public Torneo? ObtenerTorneoPorId(int id)
    {
        return _context.Torneos
                .Include(t => t.IdClubs)
                .FirstOrDefault(t => t.IdTorneo == id);
    }

    public void EliminarTorneo(int idTorneo)
    {
        var torneo = ObtenerTorneoPorId(idTorneo);

        if (torneo != null)
        {
            torneo.IdClubs.Clear(); // Limpiar la colección de clubes asociados antes de eliminar
            _context.Torneos.Remove(torneo);
            _context.SaveChanges();
        }
    }

    public void AgregarClubATorneo(int idTorneo, int idClub)
    {
        var torneo = ObtenerTorneoPorId(idTorneo);
        if (torneo != null)
        {
            var club = _context.Clubs.Find(idClub);
            if (club != null)
            {
                torneo.IdClubs.Add(club);
                _context.SaveChanges();
            }
        }
    }

    public void EliminarClubDeTorneo(int idTorneo, int idClub)
    {
        var torneo = ObtenerTorneoPorId(idTorneo);
        if (torneo != null)
        {
            var club = torneo.IdClubs.FirstOrDefault(c => c.IdClub == idClub);
            if (club != null)
            {
                torneo.IdClubs.Remove(club);
                _context.SaveChanges();
            }
        }
    }
}
