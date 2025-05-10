using Clase3.Entidades;

namespace Clase3.Servicio
{
    public interface IAutomovilServicio
    {
        List<Automovil> ObtenerTodos();
        void Agregar(Automovil auto);
    }
}
