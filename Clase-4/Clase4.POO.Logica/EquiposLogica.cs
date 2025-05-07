using Clase4.POO.Entidades;

namespace Clase4.POO.Logica;

public interface IEquiposLogica
{
    void AgregarEquipo(IEquipoDeportivo equipo);
    List<IEquipoDeportivo> ObtenerEquipos();
}

public class EquiposLogica : IEquiposLogica
{
    private List<IEquipoDeportivo> Equipos { get; set; }

    public EquiposLogica()
    {
        Equipos = new List<IEquipoDeportivo>();

        // Agregamos equipos de ejemplo
        Equipos.Add(new EquipoFutbol { Nombre = "Equipo Futbol" });
        Equipos.Add(new EquipoRugby { Nombre = "Equipo Rugby" });
        Equipos.Add(new EquipoTenisDobles { Nombre = "Equipo Tenis Dobles" });
        Equipos.Add(new EquipoBasquet { Nombre = "Equipo Basquet" });
        Equipos.Add(new EquipoVoley { Nombre = "Equipo Voley" });
    }
    public void AgregarEquipo(IEquipoDeportivo equipo)
    {
        Equipos.Add(equipo);
    }

    public List<IEquipoDeportivo> ObtenerEquipos()
    {
        return Equipos;
    }
}
