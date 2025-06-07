using MundialClubes.Entidades.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundialClubes.Logica;

public interface IArbitroLogica
{

    List<Arbitro> ObtenerTodosLosArbitros();
    void AgregarArbitro(Arbitro arbitro);
    Arbitro? ObtenerArbitroPorId(int id);
    void AgregarArbitroATorneo(int idTorneo, Arbitro arbitro);

    // void EliminarArbitro(int idArbitro);
    // void Actualizar(Arbitro arbitro);
}

public class ArbitroLogica : IArbitroLogica
{
    private readonly MundialClubesContext _context;

    public ArbitroLogica(MundialClubesContext context)
    {
        _context = context;
    }

    public void AgregarArbitro(Arbitro arbitro)
    {
        _context.Arbitros.Add(arbitro);
        _context.SaveChanges();
    }

    public void AgregarArbitroATorneo(int idTorneo, Arbitro arbitro)
    {
        var torneo = _context.Torneos.FirstOrDefault(t => t.IdTorneo == idTorneo);
        if (torneo != null)
        {
            arbitro.IdTorneos.Add(torneo);
            _context.SaveChanges();
        }
    }

    public Arbitro? ObtenerArbitroPorId(int id)
    {
        return _context.Arbitros.FirstOrDefault(a => a.IdArbitro == id);
    }

    public List<Arbitro> ObtenerTodosLosArbitros()
    {
        return _context.Arbitros.ToList();
    }
}
