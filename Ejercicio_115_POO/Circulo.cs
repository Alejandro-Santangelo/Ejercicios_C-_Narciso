// Clase Circulo que hereda de Forma
public class Circulo : Forma
{
    // Atributo privado
    private double Radio { get; set; }

    // Constructor
    public Circulo(double radio)
    {
        Radio = radio / 2 ;
        
    }

    // Implementación del método abstracto CalcularArea
    public override void CalcularArea()
    {
        
        Area = Math.PI * (Radio * Radio);
    }
}