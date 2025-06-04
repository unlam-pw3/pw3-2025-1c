using MundialDeClubes.Entidades.EF;

namespace MundialDeClubes.Logica.Interfaces;

public interface IJugadorEstrellaRepository
{
    JugadorEstrella GetJugadorEstrellaById(int id);
    List<JugadorEstrella> GetAllJugadoresEstrellas();
    void AddJugadorEstrella(JugadorEstrella jugadorEstrella);
    void UpdateJugadorEstrella(JugadorEstrella jugadorEstrella);
    void DeleteJugadorEstrella(int id);

}
