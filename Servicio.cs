using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp3.Program; 

namespace ConsoleApp3
{
    // Definición de una clase abstracta llamada Servicio
    public abstract class Servicio
    {
        public abstract void RealizarServicio();

        public abstract double CalcularCosto();

        // Método abstracto que debe ser implementado por las clases derivadas para calcular el tiempo del servicio
        public abstract double CalcularTiempo();
    }

    // Definición de una clase llamada CambioDeAceite que hereda de Servicio
    public class CambioDeAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando el cambio de aceite.");
        }

        public override double CalcularCosto()
        {
            return 50.0; 
        }

        // Implementación del método abstracto CalcularTiempo para el cambio de aceite
        public override double CalcularTiempo()
        {
            return 1.0; // Retorna el tiempo en horas que toma realizar el cambio de aceite
        }
    }

    // Definición de una clase llamada Frenos que hereda de Servicio
    public class Frenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("Realizando reparación de frenos."); 
        }

       
        public override double CalcularCosto()
        {
            return 100.0; 
        }

        // Implementación del método abstracto CalcularTiempo para la reparación de frenos
        public override double CalcularTiempo()
        {
            return 2.0; // Retorna el tiempo en horas que toma realizar la reparación de frenos
        }
    }
}
