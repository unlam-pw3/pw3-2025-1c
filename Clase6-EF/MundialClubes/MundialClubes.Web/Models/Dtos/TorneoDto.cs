namespace MundialClubes.Web.Models.Dtos;

public class TorneoDto
{
    public int IdTorneo { get; set; }
    public string Nombre { get; set; } = null!;
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public int? PremiosTotales { get; set; }
    public int? CantidadEquipos { get; set; }
    public List<ClubDto> IdClubs { get; set; } = new();
    public List<ArbitroDto> IdArbitros { get; set; } = new();

}
