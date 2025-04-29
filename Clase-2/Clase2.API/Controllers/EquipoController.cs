using Clase2.Entidad;
using Clase2.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        IEquipoServicio equipoServicio;
        public EquipoController(IEquipoServicio equipoServicio)
        {
            this.equipoServicio = equipoServicio;
        }

        [HttpGet]
        public IActionResult GetEquipos()
        {
            var equipos = equipoServicio.ObtenerEquipos();
            if (equipos == null || !equipos.Any())
            {
                return NotFound("No hay equipos disponibles.");
            }
            return Ok(equipos);
        }
        [HttpPost]
        public IActionResult AgregarEquipo([FromBody] Equipo equipo)
        {
            if (equipo == null)
            {
                return BadRequest("El equipo no puede ser nulo.");
            }
            equipoServicio.AgregarEquipo(equipo);
            return CreatedAtAction(nameof(GetEquipos), new { id = equipo.nombre }, equipo);
        }
        [HttpDelete("{nombre}")]
        public IActionResult EliminarEquipo(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest("El nombre del equipo no puede ser nulo o vacío.");
            }

            var equipo = equipoServicio.ObtenerEquipos().FirstOrDefault(e => e.nombre == nombre);
            if (equipo == null)
            {
                return NotFound("El equipo no existe.");
            }

            equipoServicio.EliminarEquipo(nombre);
            return NoContent(); // Respuesta 204: Eliminación exitosa
        }


    }
}
