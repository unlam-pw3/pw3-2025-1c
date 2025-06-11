using GestionReservas.Data.EF;
using GestionReservas.Logica;
using GestionReservas.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionReservas.Web.Controllers;

public class ReservasController : Controller
{
    private IDestinoLogica _destinoLogica;
    private IReservaLogica _reservaLogica;

    public ReservasController(IDestinoLogica destinoLogica, IReservaLogica reservaLogica)
    {
        _destinoLogica = destinoLogica;
        _reservaLogica = reservaLogica;
    }

    public async Task<IActionResult> Visualizar(int? idDestino)
    {
        ViewBag.Destinos = await _destinoLogica.ObtenerDestinosAsync();
        List<Reserva> reservas;

        if (idDestino.HasValue)
        {
            reservas = await _reservaLogica.ObtenerReservasPorDestinoAsync(idDestino.Value);
        }
        else
        {
            reservas = await _reservaLogica.ObtenerReservasAsync();
        }

        ViewBag.IdDestino = idDestino ?? 0;

        return View(reservas);
    }

    [HttpGet]
    public async Task<IActionResult> Agregar()
    {
        ViewBag.Destinos = await _destinoLogica.ObtenerDestinosAsync();
        var reserva = new ReservaModel
        {
            FechaInicio = DateTime.Now,
            FechaFin = DateTime.Now.AddDays(1)
        };
        return View(reserva);
    }

    [HttpPost]
    public async Task<IActionResult> Agregar(ReservaModel reserva)
    {
        if (ModelState.IsValid)
        {
            var nuevaReserva = new Reserva
            {
                IdDestino = reserva.IdDestino,
                CantidadPasajeros = reserva.CantidadPasajeros,
                FechaInicio = reserva.FechaInicio,
                FechaFin = reserva.FechaFin
            };
            await _reservaLogica.AgregarReservaAsync(nuevaReserva);
            return RedirectToAction("Visualizar");
        }
        ViewBag.Destinos = await _destinoLogica.ObtenerDestinosAsync();
        return View(reserva);
    }

    public async Task<IActionResult> Eliminar(int id)
    {
        await _reservaLogica.EliminarReservaAsync(id);
        return RedirectToAction("Visualizar");
    }
}
