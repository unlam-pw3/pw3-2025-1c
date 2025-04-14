using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pw3.TareaClase1.Consola;

namespace Pw3.TareaClase1.Consola;

public class Juego
{

    Respuesta[] respuestas = new Respuesta[20];

    public Juego()
    {
        guardarRespuesta("Sí, definitivamente", TipoRespuesta.Positiva);
        guardarRespuesta("Sin duda", TipoRespuesta.Positiva);
        guardarRespuesta("Puedes confiar en ello", TipoRespuesta.Positiva);
        guardarRespuesta("Sí, en efecto", TipoRespuesta.Positiva);
        guardarRespuesta("Muy probable", TipoRespuesta.Positiva);
        guardarRespuesta("Las señales apuntan a que sí", TipoRespuesta.Positiva);
        guardarRespuesta("Todo indica que sí", TipoRespuesta.Positiva);
        guardarRespuesta("Claro que sí", TipoRespuesta.Positiva);
        guardarRespuesta("Respuesta TipoRespuesta", TipoRespuesta.Positiva);
        guardarRespuesta("Absolutamente sí", TipoRespuesta.Positiva);

        guardarRespuesta("Respuesta confusa, intenta de nuevo", TipoRespuesta.Neutra);
        guardarRespuesta("Pregunta otra vez más tarde", TipoRespuesta.Neutra);
        guardarRespuesta("Mejor no decirte ahora", TipoRespuesta.Neutra);
        guardarRespuesta("No puedo predecirlo ahora", TipoRespuesta.Neutra);
        guardarRespuesta("Concéntrate y vuelve a preguntar", TipoRespuesta.Neutra);

        guardarRespuesta("No cuentes con ello", TipoRespuesta.Negativa);
        guardarRespuesta("Mi respuesta es no", TipoRespuesta.Negativa);
        guardarRespuesta("Las señales apuntan a que no", TipoRespuesta.Negativa);
        guardarRespuesta("Muy dudoso", TipoRespuesta.Negativa);
        guardarRespuesta("Lo veo poco probable", TipoRespuesta.Negativa);

    }

    public String preguntar (String inputPregunta)
    {
        int valorRandom = this.obtenerIndiceAleatorio();
        Respuesta respuestaRandom = this.respuestas[valorRandom];
        return respuestaRandom.Texto;
    }

    private int obtenerIndiceAleatorio ()
    {
        Random rnd =  new Random();
        return rnd.Next(0, 20);
    }

    private void guardarRespuesta(String respuesta, TipoRespuesta tipoRespuesta)
    {
        Respuesta r = new Respuesta(respuesta, tipoRespuesta);
        int indice = 0;
        bool agregado = false;
        while (indice < this.respuestas.Length && !agregado)
        {
            if (this.respuestas[indice] == null)
            {
                this.respuestas[indice] = r;
                agregado = true;
            }
            indice++;
        }
    }
}
