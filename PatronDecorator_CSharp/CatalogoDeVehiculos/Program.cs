using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Services.Vehicles_Models.Corolla;

namespace CatalogoDeVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vehiculos guardados en el sistema:");
            string corolla2009 = new Corolla_2009(new Vehicle()).CollectInformation();
            Console.WriteLine(corolla2009);
            string corolla2016 = new Corolla_2016(new Vehicle()).CollectInformation();
            Console.WriteLine(corolla2016);
            Console.Read();
        }
    }
}
