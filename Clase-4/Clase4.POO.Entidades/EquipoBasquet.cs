namespace Clase4.POO.Entidades;

public class EquipoBasquet : IEquipoDeportivo
{
    public string Nombre { get; set; }
    public int CantidadDeIntegrantesRequeridos() => 5;
}
