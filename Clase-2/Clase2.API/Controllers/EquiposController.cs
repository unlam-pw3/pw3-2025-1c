using Clase2.Entidad;
using Clase2.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposController : ControllerBase
    {
        IEquipoServicio equipoServicio;
        
        public EquiposController(IEquipoServicio equipoServicio)
        {
            this.equipoServicio = equipoServicio;
        }

        [HttpGet]
        public IActionResult GetEquipos()
        {
            var equipos = equipoServicio.ObtenerEquipos();
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
            return CreatedAtAction(nameof(GetEquipos), equipo);
        }

        [HttpDelete("{nombreEquipo}")]
        public IActionResult EliminarEquipo(string nombreEquipo)
        {
            if (string.IsNullOrEmpty(nombreEquipo))
            {
                return BadRequest("El nombre del equipo no puede ser nulo o vacío.");
            }
            equipoServicio.EliminarEquipo(nombreEquipo);
            return NoContent();
        }
    }
}
