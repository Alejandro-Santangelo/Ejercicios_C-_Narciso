using System;

class Program
{
    static void Main()
    {
        int contraseña;

        do
        {
            Console.Write("Ingrese su contraseña numérica: ");
            contraseña = Convert.ToInt32(Console.ReadLine());

            if (contraseña != 2222)
            {
                Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
            }
        }
        while (contraseña != 2222);

        Console.WriteLine("Contraseña correcta. CHAAAAUUUUUU.");
    }
}