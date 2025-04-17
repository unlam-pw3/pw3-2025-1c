using bola8Magica.Logica;

namespace bola8Magica.Test;

public class UnitTest1
{

      [Fact]
        public void DarRespuesta_ConPreguntaValida_RetornaRespuestaValida()
        {
            Bola8Magica bola8 = new Bola8Magica();
            string pregunta = "¿Puedo salir hoy?";

            string respuesta = bola8.darRespuesta(pregunta);

            Assert.Contains(respuesta, bola8.respuestas);
        }



        [Fact]
        public void DarRespuesta_ConPreguntaInvalida_RetornaMensajeDeError()
        {
            Bola8Magica bola8 = new Bola8Magica();
            string pregunta = "¿Que hora es?"; // No es una pregunta válida

            string respuesta = bola8.darRespuesta(pregunta);

            Assert.Equal("Por favor, haz una pregunta que se pueda responder con sí o no. La pregunta debe arrancar con ¿ y terminar con ?", respuesta);
        }

   
}