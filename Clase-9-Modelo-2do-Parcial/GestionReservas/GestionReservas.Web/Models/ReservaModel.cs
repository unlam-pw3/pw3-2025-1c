namespace GestionReservas.Web.Models;

public class ReservaModel
{
    public int IdReserva { get; set; }

    public int CantidadPasajeros { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int IdDestino { get; set; }

}
