using System;

class Program
{
    static void Main()
    {
        string usuario, contraseña;

        do
        {
            Console.Write("Ingrese su Usuario: ");
            usuario = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            contraseña = Console.ReadLine();

            if (usuario != "Cacho" || contraseña != "2222")
            {
                Console.WriteLine("Usuario o contraseña incorrectos. Intente nuevamente.");
            }
        }
        while (usuario != "Cacho" || contraseña != "2222");

        Console.WriteLine("Usuario y contraseña correctos. Hola Cacho!");
    }
}