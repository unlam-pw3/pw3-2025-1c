using System;
using System.Collections.Generic;

namespace MundialDeClubes.Entidades.EF;

public partial class Presidente
{
    public int IdPresidente { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdClub { get; set; }

    public virtual Club? IdClubNavigation { get; set; }
}
