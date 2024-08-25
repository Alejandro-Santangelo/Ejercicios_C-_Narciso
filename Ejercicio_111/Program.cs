//111: Crea un programa que pregunte al usuario su edad y su año de nacimiento.
// Si la edad que introduce no es un número válido, mostrará un mensaje de aviso.
// Lo mismo ocurrirá si el año de nacimiento no es un número válido.

using System;

namespace Ejercicio111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu edad: ");
            string? edadInput = Console.ReadLine();

            if (int.TryParse(edadInput, out int edad) && edad >= 0 && edad <= 120)
            {
                Console.Write("Ingresa tu año de nacimiento: ");
                string? añoInput = Console.ReadLine();

                if (int.TryParse(añoInput, out int año) && año >= 1900 && año <= DateTime.Now.Year)
                {
                    int edadCalculada = DateTime.Now.Year - año;
                    if (edad == edadCalculada)
                    {
                        Console.WriteLine($"Tu edad es {edad} y naciste en {año}.");
                    }
                    else
                    {
                        Console.WriteLine("La edad y el año de nacimiento no coinciden.");
                    }
                }
                else
                {
                    Console.WriteLine("El año de nacimiento no es válido.");
                }
            }
            else
            {
                Console.WriteLine("La edad no es válida.");
            }
        }
    }
}