using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Logica.Repositories;

public class PresidenteRepository(MundialDeClubesContext _context) : IPresidenteRepository
{
    public Presidente GetPresidenteById(int id)
    {
        return _context.Presidentes.FirstOrDefault(p => p.IdPresidente == id);
    }

    public List<Presidente> GetAllPresidentes()
    {
        return _context.Presidentes.ToList();
    }

    public void AddPresidente(Presidente presidente)
    {
        _context.Presidentes.Add(presidente);
        _context.SaveChanges();
    }

    public void UpdatePresidente(Presidente presidente)
    {
        _context.Presidentes.Update(presidente);
        _context.SaveChanges();
    }

    public void DeletePresidente(int id)
    {
        var presidente = _context.Presidentes.Find(id);
        if (presidente != null)
        {
            _context.Presidentes.Remove(presidente);
            _context.SaveChanges();
        }
    }
}
