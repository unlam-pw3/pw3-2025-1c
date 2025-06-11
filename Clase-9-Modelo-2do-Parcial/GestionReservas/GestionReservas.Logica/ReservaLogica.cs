using GestionReservas.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace GestionReservas.Logica;

public interface IReservaLogica
{
    Task<List<Reserva>> ObtenerReservasAsync();
    Task<List<Reserva>> ObtenerReservasPorDestinoAsync(int idDestino);
    Task<Reserva> AgregarReservaAsync(Reserva reserva);
    Task EliminarReservaAsync(int idReserva);
}

public class ReservaLogica : IReservaLogica
{
    private _20251cModel2doPGestionReservasContext _context;

    public ReservaLogica(_20251cModel2doPGestionReservasContext context)
    {
        _context = context;
    }

    public async Task<List<Reserva>> ObtenerReservasAsync()
    {
        return await _context.Reservas
            .Where(r=> !r.Eliminado)
            .ToListAsync();
    }

    public async Task<List<Reserva>> ObtenerReservasPorDestinoAsync(int idDestino)
    {
        return await _context.Reservas
            .Where(r=> !r.Eliminado && 
                    r.IdDestino == idDestino)
            .ToListAsync();
    }

    public async Task<Reserva> AgregarReservaAsync(Reserva reserva)
    {
        _context.Reservas.Add(reserva);
        await _context.SaveChangesAsync();
        return reserva;
    }

    public async Task EliminarReservaAsync(int idReserva)
    {
        var reserva = await _context.Reservas.FindAsync(idReserva);
        if (reserva == null)
            return;

        reserva.Eliminado = true;

        await _context.SaveChangesAsync();
    }
}