using MundialDeClubes.Entidades.EF;
using MundialDeClubes.Logica.Interfaces;

namespace MundialDeClubes.Logica.Services;

public class JugadorEstrellaService(IJugadorEstrellaRepository _jugadorEstrellaRepository) : IJugadorEstrellaService
{
    public JugadorEstrella GetJugadorEstrellaById(int id)
    {
        return _jugadorEstrellaRepository.GetJugadorEstrellaById(id);
    }

    public List<JugadorEstrella> GetAllJugadoresEstrellas()
    {
        return _jugadorEstrellaRepository.GetAllJugadoresEstrellas();
    }

    public void AddJugadorEstrella(JugadorEstrella jugadorEstrella)
    {
        _jugadorEstrellaRepository.AddJugadorEstrella(jugadorEstrella);
    }

    public void UpdateJugadorEstrella(JugadorEstrella jugadorEstrella)
    {
        _jugadorEstrellaRepository.UpdateJugadorEstrella(jugadorEstrella);
    }

    public void DeleteJugadorEstrella(int id)
    {
        _jugadorEstrellaRepository.DeleteJugadorEstrella(id);
    }
}
