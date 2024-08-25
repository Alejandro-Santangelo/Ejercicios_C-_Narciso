using System;

class Program
{
    public static void Main(string[] args)
    {

Console.Write("Ingrese el primer número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int menor = (num1 < num2) ? num1 : num2;

Console.WriteLine("El número menor es: " + menor);


    }

}