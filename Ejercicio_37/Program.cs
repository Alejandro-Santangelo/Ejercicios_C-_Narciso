using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 == 0)
        {
            Console.WriteLine("El producto de 0 por cualquier número es 0");
        }
        else
        {
            Console.Write("Ingrese el segundo número entero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

         if (num2 == 0)
        {
            Console.WriteLine("El producto de 0 por cualquier número es 0");
        }    
        else
        {
            int producto = num1 * num2;
            Console.WriteLine($"El producto de {num1} y {num2} es {producto}");
        }
        
       }
    }
}