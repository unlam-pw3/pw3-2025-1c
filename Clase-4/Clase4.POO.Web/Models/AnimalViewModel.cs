using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Clase4.POO.Web.Models
{
    public class AnimalViewModel
    {
        public string TipoAnimal { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public List<SelectListItem> TiposAnimales { get; set; } = new();

    }
}
