using Microsoft.AspNetCore.Mvc;
using MundialClubes.Entidades.EF;
using MundialClubes.Logica;

namespace MundialClubes.Web.Controllers
{
    public class JugadorController : Controller
    {
        private readonly IJugadorLogica _jugadorEstrellaLogica;
        public JugadorController(IJugadorLogica jugadorEstrellaLogica)
       
        {
            _jugadorEstrellaLogica = jugadorEstrellaLogica;
        }

        public IActionResult Lista()
        {
            return View(_jugadorEstrellaLogica.ObtenerTodosLosJugadores());
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(JugadorEstrella jugador)
        {
            if (ModelState.IsValid) 
            { 
            
                _jugadorEstrellaLogica.AgregarJugador(jugador);

                return Redirect("Lista");
            
            }
            return View();
        }

        
        public IActionResult Actualizar(int id)
        {
            var jugador = _jugadorEstrellaLogica.ObtenerJugadorPorId(id);

            if (jugador == null) 
            {

                return NotFound();

            }


            return View(jugador);
        }

        [HttpPost]
        public IActionResult Actualizar(JugadorEstrella jugadorEstrella)
        {

            if (ModelState.IsValid)
            {
                _jugadorEstrellaLogica.Actualizar(jugadorEstrella);

                return RedirectToAction("Lista");

            }
            return View();
        }

    
        public IActionResult Eliminar(int id)
        {
            _jugadorEstrellaLogica.EliminarJugador(id);
            return RedirectToAction("Lista");
        }


    }
}
