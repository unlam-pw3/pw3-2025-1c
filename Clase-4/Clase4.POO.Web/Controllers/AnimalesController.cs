using Clase4.POO.Entidades.AnimalesEntidades;
using Clase4.POO.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.Web.Controllers;

public class AnimalesController : Controller
{
    private IAnimal _animal;

    public AnimalesController(IAnimal animal)
    {
        _animal = animal;
    }
    public IActionResult Index()
    {
        var animales = _animal.ObtenerAnimales();
        return View(animales);
    }

    [HttpGet]
    public IActionResult Crear()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Crear(string Nombre, string Tipo)
    {
        var animal = CrearInstanciaAnimalPorTipo(Tipo);

        animal.Nombre = Nombre;
        animal.Tipo = Tipo;

        _animal.AgregarAnimal(animal);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Eliminar(string Nombre, string Tipo) {

        Animal animal = CrearInstanciaAnimalPorTipo(Tipo);
        animal.Nombre = Nombre;
        animal.Tipo = Tipo;

        _animal.EliminarAnimal(animal);

        return RedirectToAction("Index");
    }
    private Animal CrearInstanciaAnimalPorTipo(string tipoNombre)
    {
        var tipoBase = typeof(Animal);
        var tiposDerivados = AppDomain.CurrentDomain
            .GetAssemblies()
            .SelectMany(a => a.GetTypes())
            .Where(t => tipoBase.IsAssignableFrom(t) && !t.IsAbstract)
            .ToList();

        var tipoElegido = tiposDerivados.FirstOrDefault(
            t => t.Name.Equals(tipoNombre, StringComparison.OrdinalIgnoreCase));

        return Activator.CreateInstance(tipoElegido) as Animal;
    }

}
