using MundialDeClubes.Entidades.EF;

namespace MundialDeClubes.Logica.Interfaces;

public interface IPresidenteService
{
    Presidente GetPresidenteById(int id);
    List<Presidente> GetAllPresidentes();
    void AddPresidente(Presidente presidente);
    void UpdatePresidente(Presidente presidente);
    void DeletePresidente(int id);
}
