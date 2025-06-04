using System.ComponentModel.DataAnnotations;

namespace MundialDeClubes.Entidades.EF;

public partial class Club
{
    public int IdClub { get; set; }

    [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
    [MaxLength(200, ErrorMessage = "El nombre no puede exceder los 200 caracteres.")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "El campo Pais es obligatorio.")]
    [MaxLength(200, ErrorMessage = "El pais no puede exceder los 200 caracteres.")]
    public string? Pais { get; set; }

    [Required(ErrorMessage = "El campo Escudo es obligatorio.")]
    [MaxLength(500, ErrorMessage = "La URL del escudo no puede exceder los 500 caracteres.")]
    public string? EscudoUrl { get; set; }

    [Required(ErrorMessage = "El campo Camiseta es obligatorio.")]
    [MaxLength(500, ErrorMessage = "La URL de la camiseta no puede exceder los 500 caracteres.")]
    public string? CamisetaUrl { get; set; }

    public virtual ICollection<JugadorEstrella> JugadorEstrellas { get; set; } = new List<JugadorEstrella>();

    public virtual ICollection<Presidente> Presidentes { get; set; } = new List<Presidente>();
}
