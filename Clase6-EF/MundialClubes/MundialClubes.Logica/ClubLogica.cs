using MundialClubes.Entidades.EF;

namespace MundialClubes.Logica;

public interface IClubLogica
{
    List<Club> ObtenerTodosLosClubes();
    void AgregarClub(Club club);
    Club ObtenerClubPorId(int id);
    void EliminarClub(int idClub);
    void Actualizar(Club club);
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
    public Club ObtenerClubPorId(int id)
    {
        return _context.Clubs.Find(id);
    }

    public void Actualizar(Club club)
    {
        var clubExistente = _context.Clubs.Find(club.IdClub);
        if (clubExistente != null)
        {
            clubExistente.Nombre = club.Nombre;
            clubExistente.Pais = club.Pais;
            clubExistente.EscudoUrl = club.EscudoUrl;
            clubExistente.CamisetaUrl = club.CamisetaUrl;
            _context.SaveChanges();
        }
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
