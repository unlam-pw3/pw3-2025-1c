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

        public IActionResult AgregarVehiculo([FromForm] Vehiculo vehiculo, [FromForm] IFormFile? FotoUrl)
        {
            String url = String.Empty;
            if (vehiculo == null)
            {
                return BadRequest("Datos del vehículo no válidos.");
            }
            
            if(FotoUrl != null)
            {
                 url = guardarImagen(FotoUrl, vehiculo.Id);
                vehiculo.Url = url;
            }
         
            this.iVehiculosServicio.AgregarVehiculo(vehiculo);
            return Ok("Vehiculo agregago correctamente");

        }

       

        [HttpGet("ObtenerVehiculos")]
        public IActionResult ObtenerVehiculos()
        {

           

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

        [HttpPost("Editar")]

        public IActionResult Editar([FromForm] Vehiculo vehiculo, [FromForm] IFormFile? FotoUrl)
        {

            if(vehiculo == null)
            {
                return BadRequest("El vehiculo es null");
            }

            

            if(FotoUrl != null)
            {
                string foto = guardarImagen(FotoUrl, vehiculo.Id);
                vehiculo.Url = foto;
            }

            this.iVehiculosServicio.editarVehiculo(vehiculo);

            return Ok();
        }

        private String guardarImagen(IFormFile img, int id)
        {

            String url = String.Empty;

            if (img != null && img.Length > 0)
            {
                var nombreArchivo = id + Path.GetExtension(img.FileName);
                var rutaCarpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "imagenes");
                var rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

                if (!Directory.Exists(rutaCarpeta))
                    Directory.CreateDirectory(rutaCarpeta);

                using (var stream = new FileStream(rutaCompleta, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                url = "/imagenes/" + nombreArchivo;
            }

            return url;
        }
    }
}
