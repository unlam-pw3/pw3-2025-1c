using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Logica.Services;

public class ClubService(IClubRepository _clubRepository) : IClubService
{
    // Implement methods from IClubService interface using _clubRepository
    public List<Club> GetAllClubs()
    {
        return _clubRepository.GetAllClubs();
    }

    public Club GetClubById(int id)
    {
        return _clubRepository.GetClubById(id);
    }

    public void AddClub(Club club)
    {
        _clubRepository.AddClub(club);
    }

    public void UpdateClub(Club club)
    {
        _clubRepository.UpdateClub(club);
    }

    public void DeleteClub(int id)
    {
        _clubRepository.DeleteClub(id);
    }
}
