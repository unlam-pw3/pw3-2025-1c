namespace Clase4.POO.Entidades;

public class EquipoRugby : IEquipoDeportivo
{
    public string Nombre { get; set; }
    public int CantidadDeIntegrantesRequeridos() => 15;
}