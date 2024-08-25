
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 12345;
            int numero2 = 67890;
            int resultado = numero1 + numero2;

            Console.WriteLine($"El resultado de sumar {numero1} y {numero2} es: {resultado}");

            // Esperar a que el usuario presione una tecla antes de cerrar
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

