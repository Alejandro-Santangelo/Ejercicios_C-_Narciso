using System;

class Program
{
    static void Main()
    {
        int suma = 0;

        while (true)
        {
            Console.Write("Ingrese un número positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                break;
            }

            suma += num;
            Console.WriteLine("La suma actual es: " + suma);
        }

        Console.WriteLine("La suma final es: " + suma);
    }
}