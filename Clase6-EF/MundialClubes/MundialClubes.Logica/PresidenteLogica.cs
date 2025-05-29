using MundialClubes.Entidades.EF;

namespace MundialClubes.Logica;

public interface IPresidenteLogica
{
    List<Presidente> ObtenerTodosLosPresidentes();
    Presidente ObtenerPorId(int? idPresidente);
    void AgregarPresidente(Presidente presidente);
}

public class PresidenteLogica : IPresidenteLogica
{
    private readonly MundialClubesContext _context;
    public PresidenteLogica(MundialClubesContext context)
    {
        _context = context;
    }
    public Presidente ObtenerPorId(int? idPresidente)
    {
        if (idPresidente == null)
        {
            return null;
        }
        
        return _context.Presidentes.Find(idPresidente);
    }

    public List<Presidente> ObtenerTodosLosPresidentes()
    {
        return _context.Presidentes.OrderBy(p => p.Nombre).ToList();
    }

    public void AgregarPresidente(Presidente presidente)
    {
        _context.Presidentes.Add(presidente);
        _context.SaveChanges();
    }
}


