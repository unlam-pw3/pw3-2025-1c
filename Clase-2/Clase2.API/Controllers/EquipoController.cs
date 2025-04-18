using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Clase2.Logica;
using Clase2.Entidad;



namespace Clase2.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        IEquipoServicio equipoServicio;

        public EquipoController(IEquipoServicio equipoServicio)
        {
            this.equipoServicio = equipoServicio;
        }

        [HttpGet]
        public IActionResult ObtenerEquipos()
        {
            var equipos = this.equipoServicio.ObtenerEquipos();
            if (equipos == null || equipos.Count == 0)
            {
                return NotFound("No hay resultados disponibles.");
            }
            return Ok(equipos); 
        }

        [HttpPost]
        public IActionResult AgregarEquipo([FromBody] EquipoDTO equipo)
        {
            if (equipo == null)
            {
                return BadRequest("El nombre del equipo no puede ser nulo");
            }
            var equipoCreado = equipoServicio.AgregarEquipo(equipo);
            
            return CreatedAtAction(nameof(ObtenerEquipos), equipoCreado);

        }
    }
}
