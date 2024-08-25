public class Persona
{
    private int edad;
    private string nombre;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {nombre}.");
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public int GetEdad()
    {
        return edad;
    }
}