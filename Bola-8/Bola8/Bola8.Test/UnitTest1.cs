using Xunit;
using Bola8;
namespace Bola8.Test;

public class UnitTest1
{
    [Fact]
    public static void QueLaPreguntaNoSeaNullNiVacio_PreguntaVacia_RetornaPreguntaNoValida()
    {
        Bola8 bola8 = new Bola8();
        String pregunta = "";
        String pregunta2 = null;

        Assert.Equal("Pregunta no valida", bola8.Preguntar(pregunta));
        Assert.Equal("Pregunta no valida", bola8.Preguntar(pregunta2));
    }

    [Fact]
    public static void QueLaPreguntaSeaCorrecta_Pregunta_True()
    {
        Bola8 bola8 = new Bola8();
        String pregunta = "Voy a aproba la materia?";
        String respuesta = bola8.Preguntar(pregunta);

        Assert.NotEqual("Pregunta no valida", respuesta);
    }

    [Fact]
    public static void QueLaRespuestaNoSeaNullNiVacio_Pregunta_False() 
    {
        Bola8 bola8 = new Bola8();
        String pregunta = "Voy a aproba la materia?";
        String respuesta = bola8.Preguntar(pregunta);

        Assert.False(String.IsNullOrWhiteSpace(respuesta));
    }

    [Fact]
    public static void QueLaRespuestaSeaValida_Pregunta_True()
    {
        Bola8 bola8 = new Bola8();
        String pregunta = "Voy a aproba la materia?";
        String respuesta = bola8.Preguntar(pregunta);

        Assert.Contains(respuesta, bola8.Respuestas);
    }

    [Fact]
    public static void QueLasRespuestasSeanDistintas_Pregunta_True()
    {
        Bola8 bola8 = new Bola8();
        String pregunta = "Voy a aproba la materia?";
        HashSet<String> respuestas = new HashSet<String>();

        for (int i = 0; i < 10; i++)
        {
            respuestas.Add(bola8.Preguntar(pregunta));
        }

        Assert.True(respuestas.Count > 1);
    }
}