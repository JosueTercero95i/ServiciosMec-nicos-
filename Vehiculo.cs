using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Vehiculo
    {

        public virtual void RealizarMantenimiento()
        {
            Console.WriteLine("Realizando mantenimiento general del vehiculo.");

        }

        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.00;
        }

        public void Lavar()
        {
            Console.WriteLine("Lavando el vehiculo.");
        }


       
    }

}
