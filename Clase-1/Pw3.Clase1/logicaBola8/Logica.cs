using System.Diagnostics;

namespace logicaBola8;

public class Logica
{
    String[] posiblesRespuestas = {
        "Es cierto", "Es decididamente así", "Sin lugar a dudas", "Sí, definitivamente", "Puedes confiar en ello", "Como yo lo veo, sí", "Lo más probable",
        "Perspectiva buena", "Sí", "Las señales apuntan a que sí", "Respuesta confusa, vuelve a intentarlo", "Vuelve a preguntar más tarde", "Mejor no decirte ahora",
        "No se puede predecir ahora", "Concéntrate y vuelve a preguntar", "No cuentes con ello", "Mi respuesta es no", "Mis fuentes dicen que no", "Las perspectivas no son muy buenas",
        "Muy dudoso"
    };

    public String asignarRespuesta()
    {
        Random random = new Random();
        int index = random.Next(posiblesRespuestas.Length);
        return posiblesRespuestas[index];
    }

}
