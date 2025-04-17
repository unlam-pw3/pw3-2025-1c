// See https://aka.ms/new-console-template for more information
using bola8Magica.Logica;

Bola8Magica bola8 = new Bola8Magica();
Boolean seguirJugando = true;
String respuesta = "1";

do
{
    Console.WriteLine("hazle una pregunta a la bola 8 magica");
    String pregunta = Console.ReadLine();
    Console.WriteLine(bola8.darRespuesta(pregunta));

    do
    {
        Console.WriteLine("desea seguir preguntando?\n 1-Si\n 2-No");
         respuesta = Console.ReadLine();

        if (respuesta == "2")
        {
            seguirJugando = false;
        }
    } while (respuesta != "1" && respuesta !="2");
 

    

} while (seguirJugando);

