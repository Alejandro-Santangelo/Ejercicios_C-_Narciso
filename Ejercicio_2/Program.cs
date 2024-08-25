using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 118;
            int numero2 = 56;
            int resultado = numero1 + numero2;

            Console.WriteLine($"El resultado de sumar {numero1} y {numero2} es: {resultado}");

            
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
