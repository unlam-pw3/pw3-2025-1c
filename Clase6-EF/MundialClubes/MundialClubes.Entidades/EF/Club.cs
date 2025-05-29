using System;
using System.Collections.Generic;

namespace MundialClubes.Entidades.EF;

public partial class Club
{
    public int IdClub { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Pais { get; set; }

    public string? EscudoUrl { get; set; }

    public string? CamisetaUrl { get; set; }

    public virtual Presidente? Presidente { get; set; }
}
