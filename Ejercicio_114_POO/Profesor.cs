public class Profesor : Persona
{
    public Profesor(string nombre) : base(nombre)
    {
    }

    public void Explicar()
    {
        Console.WriteLine("Estoy explicando.");
    }

    public void VerEdad()
    {
        Console.WriteLine($"Mi edad es: {GetEdad()} años.");
    }
}