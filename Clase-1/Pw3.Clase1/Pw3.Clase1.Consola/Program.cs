﻿// See https://aka.ms/new-console-template for more information

using Pw3.Clase.Logica;

AdivinadorDeNumeros adivinadorDeNumeros = new AdivinadorDeNumeros(0, 100);
string pista = "";
Console.WriteLine("Bienvenido al concurso de numeros, Intente adivinar el num de 0-100!");

while (pista != "Correcto!")
{
    Console.WriteLine("Ingrese el numero:");
    string numeroIngresado = Console.ReadLine();
    pista = adivinadorDeNumeros.IntentoAdivinar(int.Parse(numeroIngresado));
    Console.WriteLine(pista);
}
Console.ReadLine();

void Sumas()
{
    Console.WriteLine("Ingrese primer numero a sumar!");
    string numero1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo numero a sumar!");
    string numero2 = Console.ReadLine();

    //Console.WriteLine("El resultado es " + (int.Parse(numero1) + int.Parse(numero2)) + "!");
    int resultadoSuma = int.Parse(numero1) + int.Parse(numero2);
    Console.WriteLine($"El resultado es {resultadoSuma}!");

    Console.ReadLine();

}


//decimal para $
//double para calculos cientificos


//Adivinar un numero random del 1 al 100 en menos de 4 intentos
//89
//frio
//25
//tibio

