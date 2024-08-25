// 30: Pedir al usuario un número y mostrar su tabla de multiplicar, usando {0},{1} y {2}. Por ejemplo, si el número es el 3, debería escribirse algo como
 //3 x 0 = 0
 //3 x 1 = 3
 //3 x 2 = 6

using System;

namespace Ejercicio_30
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ingresa un numero: ");
            int numIngresado = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
               //Console.WriteLine("{0} x {1} = {2}", numIngresado, i, numIngresado * i);

               Console.WriteLine($"{numIngresado} x {i} = {numIngresado * i}");
            }
           



        }

    }
    
}