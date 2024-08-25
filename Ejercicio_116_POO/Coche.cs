using System;

namespace Ejercicio_116_POO
{
    public class Coche : IVehiculo
    {
        private int gasolina;

        public Coche(int gasolinaInicial)
        {
            gasolina = gasolinaInicial;
        }

        public void Conducir()
        {
            if (gasolina > 0)
            {
                Console.WriteLine("El coche puede seguir funcionando .");
            }
            else
            {
                Console.WriteLine("El coche no tiene nafta suficiente para seguir funcionando .");
            }
        }

        public bool Cargar(int cantidadGasolina)
        {
            gasolina += cantidadGasolina;
            return true;
        }
    }
}
