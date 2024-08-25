//24: Crea un programa que calcule la división de dos números introducidos por el usuario, así como el resto de esa división.

using System;

namespace DivisionResto
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Ingrese el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            if (num2 != 0)
            {
                
                int division = num1 / num2;

               
                int resto = num1 % num2;

                
                Console.WriteLine($"El resultado de la división es: {division}");
                Console.WriteLine($"El resto de la división es: {resto}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }

            
            Console.ReadKey();
        }
    }
}
