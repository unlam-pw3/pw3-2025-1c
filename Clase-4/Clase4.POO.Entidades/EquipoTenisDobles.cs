namespace Clase4.POO.Entidades;

public class EquipoTenisDobles : IEquipoDeportivo
{
    public string Nombre { get; set; }
    public int CantidadDeIntegrantesRequeridos() => 2;
}
