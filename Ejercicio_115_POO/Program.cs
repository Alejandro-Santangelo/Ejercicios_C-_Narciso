// Clase Program que depende de las clases Cuadrado y Circulo
public class Program
{
    public static void Main(string[] args)
    {
        // Crear un cuadrado y calcular su área
        Cuadrado cuadrado = new Cuadrado(5);
        cuadrado.CalcularArea();
        Console.WriteLine($"Área del cuadrado: {cuadrado.Area}");

        // Crear un círculo y calcular su área
        Circulo circulo = new Circulo(5);
        circulo.CalcularArea();
        Console.WriteLine($"Área del círculo: {circulo.Area}");
    }
}