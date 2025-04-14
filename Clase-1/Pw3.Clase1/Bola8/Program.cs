// See https://aka.ms/new-console-template for more information


using logicaBola8;

Console.WriteLine("----------- BIENVENIDO AL JUEGO DE LA BOLA 8 -----------");
Logica logicaBola8 = new Logica();
int opcionMenu = 0;

do
{
    Console.WriteLine("\n¿Qué pregunta quieres hacerle a la bola 8?");
    Console.ReadLine();
    Console.WriteLine("\n" + logicaBola8.asignarRespuesta() + "\n\n");


    bool inputValido = false;
    while (!inputValido)
    {
        Console.WriteLine("¿Quieres hacer otra pregunta? (Escribe 1 para continuar o 2 para salir)");
        try
        {
            opcionMenu = int.Parse(Console.ReadLine());
            inputValido = true; 
        }
        catch
        {
            Console.WriteLine("Entrada inválida. Por favor, escribe 1 para continuar o 2 para salir.");
        }

    }

} while (opcionMenu == 1);


