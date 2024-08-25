using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > 0 && num2 > 0)
        {
            Console.WriteLine("Los dos números son positivos");
        }
        else if (num1 > 0 || num2 > 0)
        {
            Console.WriteLine("Uno de los números es positivo");
        }
        else
        {
            Console.WriteLine("Ninguno de los números es positivo");
        }
    }
}
