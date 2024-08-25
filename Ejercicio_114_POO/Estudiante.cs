public class Estudiante : Persona
{
    public Estudiante(string nombre) : base(nombre)
    {
    }

    public void Estudiar()
    {
        Console.WriteLine("Estoy estudiando.");
    }

    public void VerEdad()
    {
        Console.WriteLine($"Mi edad es: {GetEdad()} años.");
    }
}