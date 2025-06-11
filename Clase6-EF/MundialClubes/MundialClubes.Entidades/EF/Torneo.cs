using System;
using System.Collections.Generic;

namespace MundialClubes.Entidades.EF;

public partial class Torneo
{
    public int IdTorneo { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int? PremiosTotales { get; set; }

    public int? CantidadEquipos { get; set; }

    public virtual ICollection<Arbitro> IdArbitros { get; set; } = new List<Arbitro>();

    public virtual ICollection<Club> IdClubs { get; set; } = new List<Club>();
}
