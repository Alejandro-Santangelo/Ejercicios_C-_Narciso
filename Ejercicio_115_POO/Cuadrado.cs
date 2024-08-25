// Clase Cuadrado que hereda de Forma
public class Cuadrado : Forma
{
    // Atributo privado
    private double Lado { get; set; }

    // Constructor
    public Cuadrado(double lado) 
    {
        Lado = lado;
    }

    // Implementación del método abstracto CalcularArea
    public override void CalcularArea()
    {
        Area = Lado * Lado;
    }
}