using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Vehicle : IVehicle
    {
        public string Brand()
        {
            return "Marca: Toyota";
        }

        public string Model()
        {
            return "Modelo: ";
        }

        public double Price()
        {
            return 200000;
        }

        public string Type()
        {
            return "Tipo: ";
        }

        public string Year()
        {
            return "Año: ";
        }
    }
}
