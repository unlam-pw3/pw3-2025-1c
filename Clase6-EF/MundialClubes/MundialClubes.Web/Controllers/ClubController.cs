using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;

namespace MundialClubes.Web.Controllers;

public class ClubController : Controller
{
    private readonly IClubLogica _clubLogica;
    private readonly IPresidenteLogica _presidenteLogica;
    public ClubController(IClubLogica clubLogica, IPresidenteLogica presidenteLogica)
    {
        _clubLogica = clubLogica;
        _presidenteLogica = presidenteLogica;
    }

    public IActionResult Lista()
    {
        return View(_clubLogica.ObtenerTodosLosClubes());
    }

    public IActionResult Agregar()
    {
        CargarViewBagPresidentes();
        return View();
    }

    private void CargarViewBagPresidentes(int? idPresidente = null)
    {
        List<Presidente> presidentes = _presidenteLogica.ObtenerTodosLosPresidentes();

        var presidentesItems = new SelectList(presidentes.ToList(), "IdPresidente", "Nombre", idPresidente);

        ViewBag.Presidentes = presidentesItems;
    }

    [HttpPost]
    public IActionResult Agregar(Club club, int? IdPresidente, string? NuevoPresidente)
    {
        if (ModelState.IsValid)
        {
            //chequear si se ingreso un nuevo presidente
            AsignarPresidenteAClub(club, IdPresidente, NuevoPresidente);

            _clubLogica.AgregarClub(club);
            return RedirectToAction("Lista");
        }

        CargarViewBagPresidentes();
        return View(club);
    }

    private void AsignarPresidenteAClub(Club club, int? IdPresidente, string? NuevoPresidente)
    {
        if (!string.IsNullOrEmpty(NuevoPresidente))
        {
            // Si se ingresó un nuevo presidente, se crea una nueva instancia de Presidente
            club.Presidente = new Presidente
            {
                Nombre = NuevoPresidente,
                IdClub = club.IdClub // Asignar el IdClub al nuevo presidente
            };
        }
        else if (IdPresidente != null)
        {
            // Si ya existe un presidente, se asigna al club
            var presidente = _presidenteLogica.ObtenerPorId(IdPresidente);
            club.Presidente = presidente;
        }
        else
        {
            // Si no se ingresó un presidente, se elimina la referencia
            club.Presidente = null;
        }
    }

    public IActionResult Editar(int id)
    {
        var club = _clubLogica.ObtenerClubPorId(id);
        if (club == null)
        {
            return NotFound();
        }
        CargarViewBagPresidentes(club.Presidente?.IdPresidente);

        return View(club);
    }

    [HttpPost]
    public IActionResult Editar(Club club, int? IdPresidente, string? NuevoPresidente)
    {
        if (ModelState.IsValid)
        {
            AsignarPresidenteAClub(club, IdPresidente, NuevoPresidente);

            _clubLogica.Actualizar(club);
            return RedirectToAction("Lista");
        }

        CargarViewBagPresidentes(club.Presidente?.IdPresidente);
        return View(club);
    }


    //Eliminar
    public IActionResult Eliminar(int id)
    {
        _clubLogica.EliminarClub(id);
        return RedirectToAction("Lista");
    }

}
