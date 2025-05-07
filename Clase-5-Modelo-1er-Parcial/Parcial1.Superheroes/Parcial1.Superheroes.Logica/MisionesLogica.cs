using Parcial1.Superheroes.Entidades;

namespace Parcial1.Superheroes.Logica;

public interface IMisionesLogica
{
    void RegistrarMision(Mision mision);
    List<Mision> ObtenerMisiones();
}

public class MisionesLogica : IMisionesLogica
{
    private static List<Mision> _misiones = new List<Mision>();

    private void ValidarMision(Mision mision)
    {
        //validar que no sea null
        if (mision == null)
        {
            throw new ArgumentNullException(nameof(mision), "La misión no puede ser nula.");
        }
        // Validar los parámetros de entrada
        if (string.IsNullOrEmpty(mision.NombreSuperheroe))
        {
            throw new ArgumentException("El nombre del superhéroe no puede estar vacío.");
        }
        if (mision.CantidadVillanosDerrotados < 0)
        {
            throw new ArgumentException("La cantidad de villanos derrotados no puede ser negativa.");
        }
        if (mision.HorasMision < 0)
        {
            throw new ArgumentException("Las horas de misión no pueden ser negativas.");
        }
    }

    private int GenerarNuevoIdMision()
    {
        // Obtener el último ID de misión registrado
        int ultimoId = _misiones.Count > 0 ? _misiones.Max(m => m.IdMisión) : 0;
        // Asignar un nuevo ID a la nueva misión
        return ultimoId + 1;
    }
    private double CalcularIndiceEficiencia(int cantidadVillanosDerrotados, int horasMision)
    {
        if (horasMision == 0)
        {
            throw new ArgumentException("Las horas de misión no pueden ser cero.");
        }
        //(Cantidad de Villanos Derrotados * 100) / Horas de Misión
        return Math.Round(((double)cantidadVillanosDerrotados * 100 / horasMision), 2);
    }

    public void RegistrarMision(Mision mision)
    {
        ValidarMision(mision);

        // Calcular el índice de eficiencia
        mision.IndiceEficiencia = CalcularIndiceEficiencia(mision.CantidadVillanosDerrotados, mision.HorasMision);

        mision.IdMisión = GenerarNuevoIdMision();

        // Guardar nuevaMision en la base de datos o lista
        _misiones.Add(mision);
    }

    //public void RegistrarMision(string nombreSuperheroe, int cantidadVillanosDerrotados, int horasMision)
    //{
    //    // Validar los parámetros de entrada
    //    if (string.IsNullOrEmpty(nombreSuperheroe))
    //    {
    //        throw new ArgumentException("El nombre del superhéroe no puede estar vacío.");
    //    }
    //    if (cantidadVillanosDerrotados < 0)
    //    {
    //        throw new ArgumentException("La cantidad de villanos derrotados no puede ser negativa.");
    //    }
    //    if (horasMision < 0)
    //    {
    //        throw new ArgumentException("Las horas de misión no pueden ser negativas.");
    //    }

    //    Mision nuevaMision = new Mision(nombreSuperheroe, cantidadVillanosDerrotados, horasMision);

    //    // Guardar nuevaMision en la base de datos o lista
    //    _misiones.Add(nuevaMision);
    //}

    //CalcularIndiceEficiencia

    public List<Mision> ObtenerMisiones()
    {
        return _misiones
            .OrderBy(m => m.IdMisión)
            .ToList();
    }

}
