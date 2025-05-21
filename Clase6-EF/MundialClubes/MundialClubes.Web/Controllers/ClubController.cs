using Microsoft.AspNetCore.Mvc;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;

namespace MundialClubes.Web.Controllers;

public class ClubController : Controller
{
    private readonly IClubLogica _clubLogica;
    public ClubController(IClubLogica clubLogica)
    {
        _clubLogica = clubLogica;
    }

    public IActionResult Lista()
    {
        return View(_clubLogica.ObtenerTodosLosClubes());
    }

    public IActionResult Agregar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Agregar(Club club)
    {
        if (ModelState.IsValid)
        {
            _clubLogica.AgregarClub(club);
            return RedirectToAction("Lista");
        }
        return View(club);
    }

    //Eliminar
    public IActionResult Eliminar(int id)
    {
        _clubLogica.EliminarClub(id);
        return RedirectToAction("Lista");
    }

}
