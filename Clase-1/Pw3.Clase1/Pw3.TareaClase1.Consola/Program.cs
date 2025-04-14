// See https://aka.ms/new-console-template for more information
using Pw3.TareaClase1.Consola;
public class MiPrograma
{
    public static void Main()
    {

        Juego juego = new Juego();
        String opcion = "";
        do
        {
            imprimir("Escriba su pregunta cerrada (Debe responderse con Sí o No)");
            opcion = String.Format(pedirAlUsuario());
            imprimir(juego.preguntar(opcion));
            imprimir("Si desea jugar nuevamente inserte 'Sí'. Inserte 9 para salir");
            opcion = String.Format(pedirAlUsuario());
        } while (!opcion.Equals("9"));
        imprimir("Hasta luego!");

    }

    private static void imprimir(String input)
    {
        Console.WriteLine(input + "\n");
    }
    
    private static String pedirAlUsuario ()
    {
        return Console.ReadLine();
    }
}