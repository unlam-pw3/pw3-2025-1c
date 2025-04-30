using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers
{
    public class VehiculosController : Controller
    {

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }


    }
}
