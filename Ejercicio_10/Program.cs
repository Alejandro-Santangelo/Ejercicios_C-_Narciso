//10: Calcular el resultado de 15 + -5*6 / 10

using System;

namespace Ejercicio_10
{
   class Program
   {
     static void Main(string[] args)
     {
       int num1 = 15;
       int num2 = -5;
       int num3 = 6;
       int num4 = 10;
       int resultado = num1 + ((num2*num3) / num4);

       Console.WriteLine($"El resultado del calculo es =  {resultado}");

       Console.ReadKey();



     }



   }




}