using System;
using System.Collections.Generic;

namespace MundialClubes.Entidades.EF;

public partial class Arbitro
{
    public int IdArbitro { get; set; }

    public string Nombre { get; set; } = null!;

    public string Nacionalidad { get; set; } = null!;

    public virtual ICollection<Torneo> IdTorneos { get; set; } = new List<Torneo>();
}
