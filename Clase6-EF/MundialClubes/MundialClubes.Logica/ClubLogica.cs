using MundialClubes.Entidades.EF;

namespace MundialClubes.Logica;

public interface IClubLogica
{
    List<Club> ObtenerTodosLosClubes();
    void AgregarClub(Club club);
    void EliminarClub(int idClub);
}

public class ClubLogica : IClubLogica
{
    private readonly MundialClubesContext _context;
    public ClubLogica(MundialClubesContext context)
    {
        _context = context;
    }

    public List<Club> ObtenerTodosLosClubes()
    {
        return _context.Clubs.ToList();
    }

    public void AgregarClub(Club club)
    {
        _context.Clubs.Add(club);
        _context.SaveChanges();
    }

    public void EliminarClub(int idClub)
    {
        var club = _context.Clubs.Find(idClub);
        if (club != null)
        {
            _context.Clubs.Remove(club);
            _context.SaveChanges();
        }
    }
}
