using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el ancho del rectángulo: ");
        int ancho = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el alto del rectángulo: ");
        int alto = Convert.ToInt32(Console.ReadLine());

        for (int filaActual = 1; filaActual <= alto; filaActual++)
        {
            for (int columnaActual = 1; columnaActual <= ancho; columnaActual++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}