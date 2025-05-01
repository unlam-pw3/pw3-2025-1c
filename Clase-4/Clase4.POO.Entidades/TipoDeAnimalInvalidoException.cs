
namespace Clase4.POO.Logica
{
    [Serializable]
    public class TipoDeAnimalInvalidoException : Exception
    {
        public TipoDeAnimalInvalidoException()
        {
        }

        public TipoDeAnimalInvalidoException(string? message) : base(message)
        {
        }

        public TipoDeAnimalInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}