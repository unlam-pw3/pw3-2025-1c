using System.ComponentModel.DataAnnotations;

namespace Parcial1.Superheroes.Entidades;

public class Mision
{
    public Mision()
    { }
    //public Mision(string nombreSuperheroe, int cantidadVillanosDerrotados, int horasMision)
    //{
    //    NombreSuperheroe = nombreSuperheroe;
    //    CantidadVillanosDerrotados = cantidadVillanosDerrotados;
    //    HorasMision = horasMision;
    //    IndiceEficiencia = Math.Round(((double)CantidadVillanosDerrotados / HorasMision), 2);
    //}

    public int IdMisión { get; set; }

    [Required(ErrorMessage = "El nombre del superhéroe es obligatorio.")]
    [StringLength(40, ErrorMessage = "El nombre del superhéroe no puede exceder los 40 caracteres.")]
    public string NombreSuperheroe { get; set; }

    //Numérico. Campo obligatorio. Mayor a 0 y menor a 500.
    [Required(ErrorMessage = "La cantidad de villanos derrotados es obligatoria.")]
    [Range(1, 499, ErrorMessage = "La cantidad de villanos derrotados debe ser mayor a 0 y ser menor a 500.")]
    public int CantidadVillanosDerrotados { get; set; }

    //Numérico. Campo obligatorio. Mayor o igual a 1 y menor o igual a 72.
    [Required(ErrorMessage = "Las horas de misión son obligatorias.")]
    [Range(1, 72, ErrorMessage = "Las horas de misión deben estar entre 1 y 72 inclusive.")]
    public int HorasMision { get; set; }
    public double IndiceEficiencia { get; set; }

}
