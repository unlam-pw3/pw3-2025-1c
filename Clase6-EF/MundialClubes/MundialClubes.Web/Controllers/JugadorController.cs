using Microsoft.AspNetCore.Mvc;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;

namespace MundialClubes.Web.Controllers;

public class JugadorController : Controller
{
    public IJugadorEstrella _jugadorEstrellaLogica;

    public JugadorController(IJugadorEstrella _jugadorEstrellaLogica)
    {
        this._jugadorEstrellaLogica = _jugadorEstrellaLogica;
    }
    public IActionResult Agregar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Agregar(JugadorEstrella jugador)
    {
        _jugadorEstrellaLogica.Agregar(jugador);
        return RedirectToAction("Listado");
    }

    public IActionResult Listado()
    {
        return View(_jugadorEstrellaLogica.ObtenerJugadores());
    }

    [HttpGet]
    public IActionResult Eliminar(int Id)
    {
        _jugadorEstrellaLogica.Eliminar(Id);
        return RedirectToAction("Listado");
    }

    [HttpGet]
    public IActionResult Editar(int Id)
    {        
        return View(_jugadorEstrellaLogica.obtenerJugadorPorId(Id));
    }

    [HttpPost]
    public IActionResult Editar(JugadorEstrella jugadorAeditar)
    {
        _jugadorEstrellaLogica.Modificar(jugadorAeditar);
        return RedirectToAction("Listado");
    }


}
