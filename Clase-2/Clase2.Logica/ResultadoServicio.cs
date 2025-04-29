using Clase2.Entidad;

namespace Clase2.Logica
{

    public interface IResultadoServicio
    {
        void AgregarResultado(Resultado resultado);
        List<Resultado> ObtenerResultados();
        void EliminarResultados(List<Resultado> filas);

        void AgregarEquipo(Equipo equipo);
        List<Equipo> ObtenerEquipos();
        void EliminarEquipo(List<Equipo> equipo);

    }

    public class ResultadoServicio : IResultadoServicio
    {
        private List<Resultado> _resultados;
        private List<Equipo> _equipos;
        
        public ResultadoServicio()
        {
            _resultados = new List<Resultado>();
            _equipos = new List<Equipo>();
        }
        public void AgregarResultado(Resultado resultado)
        {
            _resultados.Add(resultado);
        }
        public List<Resultado> ObtenerResultados()
        {
            return _resultados;
        }

        public void EliminarResultados(List<Resultado> filas)
        {

            _resultados.RemoveAll(r => filas.Contains(r));

        }

        public void AgregarEquipo(Equipo equipo)
        {
            _equipos.Add(equipo);
        }

        public List<Equipo> ObtenerEquipos()
        {
            return _equipos;
        }

        public void EliminarEquipo(List<Equipo> equipo)
        {
            _equipos.RemoveAll(e => equipo.Contains(e));

        }
    }

}
