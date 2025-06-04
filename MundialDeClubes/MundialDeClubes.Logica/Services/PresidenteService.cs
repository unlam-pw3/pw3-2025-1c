using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Logica.Services;

public class PresidenteService : IPresidenteService
{
    private readonly IPresidenteRepository _presidenteRepository;

    public PresidenteService(IPresidenteRepository presidenteRepository)
    {
        _presidenteRepository = presidenteRepository;
    }

    public Presidente GetPresidenteById(int id)
    {
        return _presidenteRepository.GetPresidenteById(id);
    }

    public List<Presidente> GetAllPresidentes()
    {
        return _presidenteRepository.GetAllPresidentes();
    }

    public void AddPresidente(Presidente presidente)
    {
        _presidenteRepository.AddPresidente(presidente);
    }

    public void UpdatePresidente(Presidente presidente)
    {
        _presidenteRepository.UpdatePresidente(presidente);
    }

    public void DeletePresidente(int id)
    {
        _presidenteRepository.DeletePresidente(id);
    }
}
