using Microsoft.AspNetCore.Mvc;
using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Web.Controllers;

public class ClubController(IClubService _clubService) : Controller
{

    public IActionResult Listar()
    {
        var clubs = _clubService.GetAllClubs();
        return View(clubs);
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
            _clubService.AddClub(club);
            return RedirectToAction("Listar");
        }
        return View(club);
    }

    public IActionResult Editar(int id)
    {
        var club = _clubService.GetClubById(id);
        if (id == 0)
        {
            return NotFound();
        }

        return View("Editar", club);
    }

    [HttpPost]
    public IActionResult Editar(Club club)
    {
        if (!ModelState.IsValid)
        {
            return View(club);
        }
        // Aquí podrías actualizar el club por su ID
        _clubService.UpdateClub(club);
        return RedirectToAction("Listar");
    }

    public IActionResult Eliminar(int id)
    {
        if (id == 0)
        {
            return NotFound();
        }
        _clubService.DeleteClub(id);
        return RedirectToAction("Listar");
    }
}
