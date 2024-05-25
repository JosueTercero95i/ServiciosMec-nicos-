using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellom world");
            Vehiculo MiCoche = new Coche();
            MiCoche.RealizarMantenimiento();
            Console.WriteLine("Costo del mantimiento: $" + MiCoche.ObtenerCostoMantenimiento());

            Vehiculo MiMoto = new Moto();
            MiMoto.RealizarMantenimiento();
            Console.WriteLine("Costo del mantenimiento de la (Moto): $" + MiMoto.ObtenerCostoMantenimiento());

            MiCoche.Lavar();
            Coche MiCocheReal = new Coche();
            MiCocheReal.Lavar();


            Servicio ServicioAceite = new CambioDeAceite();
            Console.WriteLine("Costo del cambio de aceite (Moto): $ " + ServicioAceite.CalcularCosto());

            ServicioAceite.RealizarServicio();


            Servicio ServicioFrenos = new Frenos();
            ServicioFrenos.RealizarServicio();
            Servicio TiempoFrenosCarros = new Frenos();
            TiempoFrenosCarros.CalcularTiempo();
            Console.WriteLine("Tiempo estimado para la reparación: " + ServicioFrenos.CalcularTiempo() + " hora");

            Console.WriteLine("Costo del cambio de aceite (Carro) : $ " + ServicioFrenos.CalcularCosto());


            Servicio TiempoAceiteCarros = new CambioDeAceite();
            TiempoAceiteCarros.RealizarServicio();

            Console.WriteLine("El tiempo para realizar el cambio de aceite (Carro) es de: " + ServicioAceite.CalcularTiempo() + " hora");
           
            Console.ReadLine();

           
        }

    
    }
}
