//22: Crea un programa que convierta una cantidad prefijada de metros (por ejemplo, 3000) a millas.
// La equivalencia es 1 milla = 1609 metros. Usa comentarios donde te parezca adecuado.

using System;

namespace Ejercicio_22
{
  class Program
  {

    static void Main(string[] args)
    {
      float cantidadMetros = 3000;
      float metrosEnMilla =  1609;
      float resultado = cantidadMetros / metrosEnMilla ;

      Console.WriteLine($"En {cantidadMetros} metros hay :  {resultado} millas");

      Console.ReadKey();


    }
  }

}