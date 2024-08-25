// Clase Program con el método Main
using System;
namespace Ejercicio_116_POO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Coche coche = new Coche(0);
            Console.Write("Ingrese la cantidad de gasolina para cargar: ");
            int cantidadGasolina = Convert.ToInt32(Console.ReadLine());
            coche.Cargar(cantidadGasolina);
            coche.Conducir();
        }
    }
}