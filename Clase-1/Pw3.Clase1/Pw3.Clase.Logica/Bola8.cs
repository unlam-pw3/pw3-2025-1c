namespace Pw3.Clase.Logica;

public class Bola8
{
    
    public Bola8() { 
        
    }

    public string obtenerRespuesta()
    {
        Random rnd = new Random();

        string[] respuestas = new string[]
         {
            "Si",
            "No",
            "Quizas",
            "Definitivamente",
            "No lo creo",
            "Tal vez",
            "Es probable",
            "No es probable",
            "Nunca!"
         };

        int _numeroGenerado = rnd.Next(respuestas.Length);

        return respuestas[_numeroGenerado];


    }

}
