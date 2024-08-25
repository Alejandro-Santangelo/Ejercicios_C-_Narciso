// 23: Crea un programa que calcule el producto de dos números introducidos por el usuario.

using System;

namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el primer número: ");
           
            float num1 = Convert.ToSingle(Console.ReadLine());

            
            Console.Write("Ingrese el segundo número: ");
            
            float num2 = Convert.ToSingle(Console.ReadLine());

            
            float producto = num1 * num2;

           
            Console.WriteLine($"El producto de la multiplicacion  {num1} x {num2} es = {producto}");

            
            Console.ReadKey();
        }
    }
}
