using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantimiento de la moto: lubricacion de cadena y revision de los neumaticos.");
        }

        public override double ObtenerCostoMantenimiento()
        {
            return 100.0;
        }
       


    }


}
