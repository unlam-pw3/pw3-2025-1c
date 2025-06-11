using GestionReservas.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace GestionReservas.Logica;

public interface IDestinoLogica
{
    Task<List<Destino>> ObtenerDestinosAsync();
}

public class DestinoLogica: IDestinoLogica
{
    private readonly _20251cModel2doPGestionReservasContext _context;
    public DestinoLogica(_20251cModel2doPGestionReservasContext context)
    {
        _context = context;
    }
    public async Task<List<Destino>> ObtenerDestinosAsync()
    {
        return await _context.Destinos
                .OrderBy(d=> d.Nombre)
                .ToListAsync();
    }
}
