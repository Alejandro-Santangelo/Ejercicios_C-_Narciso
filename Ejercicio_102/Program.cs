using System;

class Program
{
    static void Main()
    {
        const int numeroSecreto = 42; // Número prefijado entre 1 y 100
        int intentos = 0;
        int maxIntentos = 6;

        Console.WriteLine("Adivina el número secreto entre 1 y 100");

        while (intentos < maxIntentos)
        {
            Console.Write("Intento " + (intentos + 1) + ": ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < numeroSecreto)
            {
                Console.WriteLine("Muy chiquito");
            }
            else if (numero > numeroSecreto)
            {
                Console.WriteLine("Muy grande");
            }
            else
            {
                Console.WriteLine("¡Felicidades! Has adivinado el número secreto en " + (intentos + 1) + " intentos");
                break;
            }

            intentos++;
        }

        if (intentos == maxIntentos)
        {
            Console.WriteLine("Lo siento, has agotado tus intentos. El número secreto era " + numeroSecreto);
        }
    }
}