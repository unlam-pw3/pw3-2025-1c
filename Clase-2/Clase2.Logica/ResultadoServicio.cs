using Clase2.Entidad;

namespace Clase2.Logica
{

    public interface IResultadoServicio
    {
        void AgregarResultado(Resultado resultado);
        List<Resultado> ObtenerResultados();
    }

    public class ResultadoServicio : IResultadoServicio
    {
        private List<Resultado> _resultados;
        
        public ResultadoServicio()
        {
            _resultados = new List<Resultado>();
        }
        public void AgregarResultado(Resultado resultado)
        {
            _resultados.Add(resultado);
        }
        public List<Resultado> ObtenerResultados()
        {
            return _resultados;
        }

    }
}
