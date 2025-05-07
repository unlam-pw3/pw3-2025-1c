using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Clase4.POO.Web.Models
{
    public class AnimalViewModel
    {
        [Required(ErrorMessage = "El tipo de animal es obligatorio")]
        [Display(Name = "Tipo de animal")]
        public string Tipo { get; set; }

        public List<SelectListItem> Tipos => new List<SelectListItem>
        {
            new SelectListItem { Value = "Perro", Text = "Perro" },
            new SelectListItem { Value = "Gato", Text = "Gato" },
            new SelectListItem { Value = "Vaca", Text = "Vaca" },
            new SelectListItem { Value = "Gallina", Text = "Gallina" },
            new SelectListItem { Value = "Leon", Text = "Leon" }
        };
    }
}