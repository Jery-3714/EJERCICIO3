
using System.Security.Cryptography;

int Num1, Num2, resultado;
    {

    Console.Write("Ingrese el primer número: ");
    Num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el segundo número: ");
    Num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese la operacion matematica a realizar: ");
    int opcion = Convert.ToInt32(Console.ReadLine());



    switch (opcion)
    {
        case 1: Console.WriteLine($"Suma de ambos numeros es: {Num1} + {Num2} = {Num1 + Num2}"); break;

        case 2: Console.WriteLine($"Resta de ambos numeros es: {Num1} - {Num2} = {Num1 - Num2}"); break;

        case 3: Console.WriteLine($"Multiplicacion de ambos numeros es: {Num1} * {Num2} = {Num1 * Num2}"); break;

        case 4: Console.WriteLine($"Division de ambos numeros es: {Num1} / {Num2} = {Num1 / Num2}"); break;
        default: Console.WriteLine("Número inválido"); break;

    Console.WriteLine("\nPresiona ENTER para salir...");
    Console.ReadLine();
    }





}