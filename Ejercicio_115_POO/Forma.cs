using System;

// Clase abstracta Forma
public abstract class Forma
{
  

    // Atributo protegido
    public double Area { get; set; }

    
    

    // Método abstracto para calcular el área
    public abstract void CalcularArea();
}