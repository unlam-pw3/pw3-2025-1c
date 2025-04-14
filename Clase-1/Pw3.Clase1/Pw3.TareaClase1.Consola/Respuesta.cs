using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pw3.TareaClase1.Consola;

public class Respuesta
{
    public string Texto { get; set; }
    public TipoRespuesta Tipo { get; set; }

    public Respuesta (String respuesta, TipoRespuesta tipo)
    {
        this.Texto = respuesta;
        this.Tipo = tipo;
    }
}
