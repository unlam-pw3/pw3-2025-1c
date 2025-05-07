namespace Clase4.POO.Entidades;

public class EquipoVoley : IEquipoDeportivo
{
    public string Nombre { get; set; }
    public int CantidadDeIntegrantesRequeridos() => 6;
}
