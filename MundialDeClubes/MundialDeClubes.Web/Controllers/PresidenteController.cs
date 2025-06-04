using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Web.Controllers
{
    public class PresidenteController(IPresidenteService _presidenteService, IClubService _clubService) : Controller
    {
        public IActionResult Agregar()
        {
            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Presidente presidente)
        {
            if (ModelState.IsValid)
            {
                // Aquí podrías agregar el presidente a la base de datos
                _presidenteService.AddPresidente(presidente);
                return RedirectToAction("Listar");
            }
            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");
            return View(presidente);
        }

        public IActionResult Listar()
        {
            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");
            var presidentes = _presidenteService.GetAllPresidentes();
            return View(presidentes);
        }

        public IActionResult Editar(int id)
        {
            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");
            var presidente = _presidenteService.GetPresidenteById(id);
            if (presidente == null)
            {
                return NotFound();
            }

            return View("Editar", presidente);
        }
        [HttpPost]
        public IActionResult Editar(Presidente presidente)
        {
            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");
            if (!ModelState.IsValid)
            {
                return View(presidente);
            }
            _presidenteService.UpdatePresidente(presidente);
            return RedirectToAction("Listar");
        }

        public IActionResult Eliminar(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            _presidenteService.DeletePresidente(id);
            return RedirectToAction("Listar");
        }
    }
}
