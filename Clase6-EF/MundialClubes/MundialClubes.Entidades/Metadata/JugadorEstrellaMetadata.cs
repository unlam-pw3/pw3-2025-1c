using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundialClubes.Entidades.Metadata;

public class JugadorEstrellaMetadata
{
    [Required (ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "La edad es obligatoria")]
    public int Edad { get; set; }

    [MaxLength(500, ErrorMessage = "La url debe ser menor a 500 caracteres")]
    public string? FotoUrl { get; set; }
}
