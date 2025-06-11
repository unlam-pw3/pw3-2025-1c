using System;
using System.Collections.Generic;

namespace GestionReservas.Data.EF;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int CantidadPasajeros { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int IdDestino { get; set; }

    public bool Eliminado { get; set; }

    public virtual Destino IdDestinoNavigation { get; set; } = null!;
}
