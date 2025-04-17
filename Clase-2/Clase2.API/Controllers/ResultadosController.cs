using Clase2.Entidad;
using Clase2.Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultadosController : ControllerBase
    {
        IResultadoServicio resultadoServicio;
        public ResultadosController(IResultadoServicio resultadoServicio)
        {
            this.resultadoServicio = resultadoServicio;
        }

        [HttpGet]
        public IActionResult GetResultados()
        {
            var resultados = resultadoServicio.ObtenerResultados();
            if (resultados == null || !resultados.Any())
            {
                return NotFound("No hay resultados disponibles.");
            }
            return Ok(resultados);
        }
        [HttpPost]
        public IActionResult AgregarResultado([FromBody] Resultado resultado)
        {
            if (resultado == null)
            {
                return BadRequest("El resultado no puede ser nulo.");
            }
            resultadoServicio.AgregarResultado(resultado);
            return CreatedAtAction(nameof(GetResultados), new { id = resultado.fecha }, resultado);
        }

    }
}
