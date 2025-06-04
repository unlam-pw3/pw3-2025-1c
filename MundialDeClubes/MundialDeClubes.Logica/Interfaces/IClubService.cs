using MundialDeClubes.Entidades.EF;

namespace MundialDeClubes.Logica.Interfaces;

public interface IClubService
{
    Club GetClubById(int id);
    List<Club> GetAllClubs();
    void AddClub(Club club);
    void UpdateClub(Club club);
    void DeleteClub(int id);
}
