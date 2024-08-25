using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine($"El número {num} es múltiplo de 2");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine($"El número {num} es múltiplo de 3");
        }
        else
        {
            Console.WriteLine($"El número {num} no es múltiplo de 2 ni de 3");
        }
    }
}
