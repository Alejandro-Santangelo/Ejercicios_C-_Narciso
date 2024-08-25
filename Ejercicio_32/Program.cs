//32: Crea un programa que convierta de grados Celsius (centígrados) a Kelvin y a Fahrenheit:
// pedirá al usuario la cantidad de grados centígrados y usará las siguiente tablas de conversión:
// kelvin = celsius + 273 ; fahrenheit = celsius x 18 / 10 + 32. 
//Emplea "Write" en vez de "{0}" cuando debas mostrar varios datos en la misma línea.

using System;

namespace Ejercicio_32
{
   partial class Ejercicio_32
   {
      public static void Main(string[] args)
      {
         Console.Write("Ingresa la cantidad de grados a convertir :");
         int gradosIngresados = Convert.ToInt32(Console.ReadLine());  

        int gradosKelvin = gradosIngresados + 273;
        int gradosFahrenheit = ((gradosIngresados * 18) / 10) + 32;

         Console.WriteLine($"Los grados Centigrados que ingresaste equivalen a {gradosKelvin}  grados Kelvin , y a  {gradosFahrenheit} Grados Fahrenheit"); 
         //Console.WriteLine($"Los grados Centigrados que ingresaste equivalen a {gradosKelvin} grados Kelvin, y a {gradosFahrenheit} Grados Fahrenheit");
         Console.WriteLine("Los grados Centigrados que ingresaste equivalen a " + gradosKelvin + " grados Kelvin, y a " + gradosFahrenheit + " Grados Fahrenheit");

      }
       


   }



}