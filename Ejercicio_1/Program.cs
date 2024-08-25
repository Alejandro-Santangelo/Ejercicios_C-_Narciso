using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine() ?? "Usuario";


            
            Console.WriteLine($"Hola, {nombre}.");

            
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

