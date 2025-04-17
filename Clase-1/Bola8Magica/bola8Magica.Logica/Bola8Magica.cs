using System.Text.RegularExpressions;

namespace bola8Magica.Logica
{
    public class Bola8Magica
    {
      
      public string[] respuestas { get; set; } = new string[]
      {
        "si",
        "Es cierto",
        "Es decididamente asi",
        "Sin lugar a dudas",
        "Sí, definitivamente",
        "Puedes confiar en ello",
        "Como yo lo veo, sí",
        "Lo más probable",
        "Perspectiva buena",
        "Las señales apuntan a que sí",
        "Respuesta confusa, vuelve a intentarlo",
        "Vuelve a preguntar más tarde",
        "Mejor no decirte ahora",
        "No se puede predecir ahora",
        "Concéntrate y vuelve a preguntar",
        "No cuentes con ello",
        "Mi respuesta es no",
        "Mis fuentes dicen que no",
        "Las perspectivas no son muy buenas",
        "Muy dudoso"
      };

        int numeroRandom;


        public String darRespuesta(String pregunta)
        {

            if (!EsPreguntaValida(pregunta))
            {
                return "Por favor, haz una pregunta que se pueda responder con sí o no. La pregunta debe arrancar con ¿ y terminar con ?";
            }

            Random rand = new Random();
            this.numeroRandom = rand.Next(0, 19);
            return this.respuestas[this.numeroRandom];
        }

        private bool EsPreguntaValida(string pregunta)
        {
            Regex regex = new Regex(@"^\s*¿\s*(puedo|debo|crees|es|tengo|sería|habría|voy|estaré|debería)\b.*\?\s*$", RegexOptions.IgnoreCase);
            return regex.IsMatch(pregunta);
        }
    }
}
