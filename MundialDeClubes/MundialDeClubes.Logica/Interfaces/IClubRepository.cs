using MundialDeClubes.Entidades.EF;

namespace MundialDeClubes.Logica.Interfaces
{
    public interface IClubRepository
    {
        // Define methods for club repository operations
        List<Club> GetAllClubs();
        Club GetClubById(int id);
        void AddClub(Club club);
        void UpdateClub(Club club);
        void DeleteClub(int id);
    }
}
