using System.ComponentModel.DataAnnotations;

namespace MundialClubes.Entidades.Metadata;

public class ClubMetadata
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    [MaxLength(500, ErrorMessage = "La URL del escudo no puede superar los 500 caracteres.")]
    public string? EscudoUrl { get; set; }

    [MaxLength(500, ErrorMessage = "La URL de la camiseta no puede superar los 500 caracteres.")]
    public string? CamisetaUrl { get; set; }
}
