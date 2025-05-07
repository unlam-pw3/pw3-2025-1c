namespace Clase4.POO.Entidades;

public class EquipoFutbol : IEquipoDeportivo
{
    public string Nombre { get; set; }
    public int CantidadDeIntegrantesRequeridos() => 11;
}
