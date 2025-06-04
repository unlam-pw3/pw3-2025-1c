using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Logica.Repositories;

public class ClubRepository(MundialDeClubesContext _context) : IClubRepository
{
    public Club GetClubById(int id)
    {
        return _context.Clubs.FirstOrDefault(c => c.IdClub == id);
    }

    public List<Club> GetAllClubs()
    {
        return _context.Clubs.ToList();
    }

    public void AddClub(Club club)
    {
        _context.Clubs.Add(club);
        _context.SaveChanges();
    }
    public void UpdateClub(Club club)
    {
        _context.Clubs.Update(club);
        _context.SaveChanges();
    }
    public void DeleteClub(int id)
    {
        var club = _context.Clubs.Find(id);
        if (club != null)
        {
            _context.Clubs.Remove(club);
            _context.SaveChanges();
        }
    }
}
