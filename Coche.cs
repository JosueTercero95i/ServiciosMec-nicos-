using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantimiento del coche: cambio de aceite y revision de frenos.");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 150.0;
        }

        public new void Lavar()
        {
            Console.WriteLine("Lavando el coche con cera y shampoo especial.");
        }
    }
}
