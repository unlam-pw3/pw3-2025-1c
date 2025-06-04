using Clase4.POO.Entidades;

namespace Clase4.POO.Logica;

public interface IAnimalesLogica
{
    void AgregarAnimal(IAnimales animal);
    List<IAnimales> ObtenerAnimales();
}
