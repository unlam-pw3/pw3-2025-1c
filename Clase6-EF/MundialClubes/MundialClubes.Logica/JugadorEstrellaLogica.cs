using Microsoft.EntityFrameworkCore;
using MundialClubes.Entidades.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundialClubes.Logica;

public interface IJugadorEstrella {
    void Agregar(JugadorEstrella jugadorEstrella);
    List<JugadorEstrella> ObtenerJugadores();
    void Eliminar(int Id);
    void Modificar(JugadorEstrella jugadorEstrella);

    JugadorEstrella obtenerJugadorPorId(int Id);

}
public class JugadorEstrellaLogica : IJugadorEstrella
{
    public readonly MundialClubesContext _mundialClubesContext;
    public JugadorEstrellaLogica(MundialClubesContext _mundialClubesContext) {
        this._mundialClubesContext = _mundialClubesContext;
    }
    public void Agregar(JugadorEstrella jugadorEstrella)
    {
        _mundialClubesContext.JugadorEstrellas.Add(jugadorEstrella);
        _mundialClubesContext.SaveChanges();
    }

    public void Eliminar(int Id)
    {
        var jugador = _mundialClubesContext.JugadorEstrellas.Find(Id);
        if (jugador != null)
        {
            _mundialClubesContext.JugadorEstrellas.Remove(jugador);
            _mundialClubesContext.SaveChanges();
        }
    }

    public void Modificar(JugadorEstrella jugadorEstrella)
    {
        var jugador = _mundialClubesContext.JugadorEstrellas.Find(jugadorEstrella.IdJugadorEstrella);
        if (jugador != null) { 
            jugador.Nombre = jugadorEstrella.Nombre;
            jugador.Descripcion = jugadorEstrella.Descripcion;
            jugador.Edad = jugadorEstrella.Edad;
            jugador.FotoUrl = jugadorEstrella.FotoUrl;
            _mundialClubesContext.SaveChanges();
        }
    }

    public List<JugadorEstrella> ObtenerJugadores()
    {
        return _mundialClubesContext.JugadorEstrellas.ToList();
    }

    public JugadorEstrella obtenerJugadorPorId(int Id)
    {
        JugadorEstrella jugador = _mundialClubesContext.JugadorEstrellas.Find(Id);
        return jugador;
    }
}
