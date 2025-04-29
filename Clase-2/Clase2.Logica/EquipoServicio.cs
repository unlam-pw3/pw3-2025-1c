using Clase2.Entidad;
namespace Clase2.Logica;


public interface IEquipoServicio
{
    void AgregarEquipo(Equipo Equipo);
    List<Equipo> ObtenerEquipos();
    void EliminarEquipo(string nombreEquipo);
}

public class EquipoServicio : IEquipoServicio
{
    private List<Equipo> _equipos;
    public EquipoServicio()
    {
        _equipos = new List<Equipo>();
    }
    public void AgregarEquipo(Equipo equipo)
    {
        _equipos.Add(equipo);
    }
    public List<Equipo> ObtenerEquipos()
    {
        return _equipos;
    }

    public void EliminarEquipo(string nombreEquipo)
    {
        var equipo = _equipos.FirstOrDefault(e => e.nombre == nombreEquipo);
        if (equipo != null)
        {
            _equipos.Remove(equipo);
        }
    }
}
