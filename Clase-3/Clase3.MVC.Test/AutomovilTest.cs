using Xunit;
using Clase3.MVC.Servicio;
using Clase3.MVC.Entidades;

namespace Clase3.MVC.Test
{
    public class AutomovilTest
    {
        [Fact]
        public void QueSePuedaAgregarUnAutomovilAlListado()
        {
            AutomovilServicio automovilServicio = new AutomovilServicio();
        }
    }
}