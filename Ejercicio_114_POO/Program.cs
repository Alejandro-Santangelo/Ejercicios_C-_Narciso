class Program
{
    
       static void Main(string[] args)
    {
        // Crear un nuevo Estudiante, establecer una edad cualquiera, hacer que salude, mostrar su edad en pantalla y empezar a estudiar
        Estudiante estudiante = new Estudiante("Cacho");
        estudiante.SetEdad(61);
        estudiante.Saludar();
        estudiante.VerEdad();
        estudiante.Estudiar();

        // Crear un nuevo Profesor, establecer una edad cualquiera, saludar y empezar la explicación
        Profesor profesor = new Profesor("Narciso");
        profesor.SetEdad(55);
        profesor.Saludar();
        profesor.VerEdad();
        profesor.Explicar();
    }
}
