using System.Text.Json;
using Clase3.MVC.Entidades;
using Clase3.MVC.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers.api
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ConcesionariaController : ControllerBase
    {

        IVehiculosServicio iVehiculosServicio;

        public ConcesionariaController(IVehiculosServicio iVehiculosServicio)
        {
            this.iVehiculosServicio = iVehiculosServicio;
        }

        [HttpPost("AgregarVehiculo")]

        public IActionResult AgregarVehiculo([FromBody] Vehiculo vehiculo)
        {
            if (vehiculo == null)
            {
                return BadRequest("Datos del vehículo no válidos.");
            }

            Console.WriteLine(vehiculo.Marca);

            this.iVehiculosServicio.AgregarVehiculo(vehiculo);
            return Ok("Vehiculo agregago correctamente");

        }

        [HttpGet("ObtenerVehiculos")]
        public IActionResult ObtenerVehiculos()
        {

            Console.WriteLine(this.iVehiculosServicio.ObtenerVehiculos().Count());

            return Ok(this.iVehiculosServicio.ObtenerVehiculos());


        }

        [HttpDelete("Eliminar")]

        public IActionResult EliminarVehiculo([FromQuery] int id)
        {
            Console.WriteLine("hola:" + id);
          

            int a = this.iVehiculosServicio.EliminarVehiculo(id);

            if(a > 0)
            {
                return Ok("Eliminado");
            }

            return Ok();


        }

        [HttpGet("Buscar")]
        public IActionResult Buscar([FromQuery] string Buscar)
        {

            return Ok(this.iVehiculosServicio.BuscarVehiculo(Buscar));

        }
    }
}
