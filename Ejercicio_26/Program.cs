// 26: Pide al usuario una cantidad de "millas náuticas" y muestra la equivalencia en metros, usando: 1 milla náutica = 1852 metros.

using System;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese la cantidad de millas náuticas
            Console.WriteLine("Ingrese la cantidad de millas náuticas:");
            double millasNauticas = Convert.ToDouble(Console.ReadLine());

            // Definir la equivalencia de una milla náutica en metros
            double metrosPorMillaNautica = 1852;

            // Calcular la equivalencia en metros
            double metros = millasNauticas * metrosPorMillaNautica;

            // Mostrar el resultado en la consola
            Console.WriteLine($"{millasNauticas} millas náuticas equivalen a {metros} metros.");

            // Esperar a que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
