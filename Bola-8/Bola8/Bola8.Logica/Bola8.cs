namespace Bola8;

public class Bola8
{
    private String[] respuestas = [
        "Es cierto",
        "Es decididamente así",
        "Sin lugar a dudas",
        "Sí, definitivamente",
        "Puedes confiar en ello",
        "Como yo lo veo, si",
        "Lo mas probable",
        "Perspectiva buena",
        "Sí",
        "Las señales apuntan a que sí",
        "Respuesta confusa, vuelve a preguntar",
        "Vuelve a preguntar más tarde",
        "Mejor no decirte ahora",
        "No se puede predecir ahora",
        "Concentrate y vuelve a preguntar",
        "No cuentes con ello",
        "Mi respuesta es no",
        "Mis fuentes dicen que no",
        "Las perspectivas no son muy buenas",
        "Muy dudoso"
        ];
    private Random random = new Random();
    public String[] Respuestas => respuestas;

    public String Preguntar(String pregunta)
    {
        String respuesta = "";
        if (ValidarQueLaPreguntaExista(pregunta))
        {
            respuesta = "Pregunta no valida";
        }
        else
        {
            respuesta = respuestas[GenerarNumeroRandom()];
        }

        return respuesta;
    }

    private int GenerarNumeroRandom()
    {
        return random.Next(respuestas.Length);
    }

    private Boolean ValidarQueLaPreguntaExista(String pregunta)
    {
        return String.IsNullOrWhiteSpace(pregunta);
    }
}
