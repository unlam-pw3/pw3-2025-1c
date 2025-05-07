using Microsoft.AspNetCore.Mvc;

namespace Parcial1.Superheroes.Web.Controllers
{
    public class PresentacionController : Controller
    {
        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
