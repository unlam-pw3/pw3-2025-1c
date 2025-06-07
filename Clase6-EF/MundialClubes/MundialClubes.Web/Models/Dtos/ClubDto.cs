namespace MundialClubes.Web.Models.Dtos;

public class ClubDto
{
    public int IdClub { get; set; }
    public string Nombre { get; set; } = null!;
    public string Pais { get; set; } = null!;
    public string EscudoUrl { get; set; } = null!;
    public string CamisetaUrl { get; set; } = null!;
}
