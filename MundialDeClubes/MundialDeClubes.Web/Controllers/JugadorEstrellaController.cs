using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Web.Controllers
{
    public class JugadorEstrellaController(IJugadorEstrellaService _jugadorEstrellaService, IClubService _clubService) : Controller
    {
        public IActionResult Listar()
        {
            var jugadoresEstrellas = _jugadorEstrellaService.GetAllJugadoresEstrellas();
            return View(jugadoresEstrellas);
        }
        public IActionResult Agregar()
        {
            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(JugadorEstrella jugadorEstrella)
        {
            if (ModelState.IsValid)
            {
                _jugadorEstrellaService.AddJugadorEstrella(jugadorEstrella);
                return RedirectToAction("Listar");
            }

            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubes = new SelectList(clubes, "Id", "Nombre", jugadorEstrella.IdClub);
            return View(jugadorEstrella);
        }

        public IActionResult Editar(int id) //EN EL GET RECIBIMOS EL ID, Buscamos por id al jugador y lo mandamos a la vista editar con sus datos
                                            //Nos damos cuenta de eso porque en el ASP-ROUTE-ID de la vista listar le pega al ID
        {
            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");
            var jugadorEstrella = _jugadorEstrellaService.GetJugadorEstrellaById(id);
            if (jugadorEstrella == null)
            {
                return NotFound();
            }
            return View("Editar", jugadorEstrella);
        }

        [HttpPost] //Con el post, agarramos al jugador y updateamos
        public IActionResult Editar(JugadorEstrella jugadorEstrella)
        {
            if (ModelState.IsValid)
            {
                _jugadorEstrellaService.UpdateJugadorEstrella(jugadorEstrella);
                return RedirectToAction("Listar");
            }

            var clubes = _clubService.GetAllClubs();
            ViewBag.Clubs = new SelectList(clubes, "IdClub", "Nombre");

            return View(jugadorEstrella);



        }

        public IActionResult Eliminar(int id)
        {
            var jugadorEstrella = _jugadorEstrellaService.GetJugadorEstrellaById(id);
            if (jugadorEstrella == null)
            {
                return NotFound();
            }
            _jugadorEstrellaService.DeleteJugadorEstrella(id);
            return RedirectToAction("Listar");
        }

    }
}
