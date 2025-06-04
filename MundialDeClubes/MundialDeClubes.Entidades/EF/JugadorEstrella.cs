namespace MundialDeClubes.Entidades.EF;

public partial class JugadorEstrella
{
    public int IdJugadorEstrella { get; set; }

    public string Nombre { get; set; } = null!;

    public string Edad { get; set; } = null!;

    public string? FotoUrl { get; set; }

    public string? Descripcion { get; set; }

    public int? IdClub { get; set; }

    public virtual Club? IdClubNavigation { get; set; }
}
