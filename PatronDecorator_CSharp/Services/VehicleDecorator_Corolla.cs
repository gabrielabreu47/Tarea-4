using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public abstract class VehicleDecorator_Corolla : IVehicle
    {
        private readonly IVehicle _vehicle;

        public VehicleDecorator_Corolla(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        public abstract string CollectInformation();

        public string Brand()
        {
            return _vehicle.Brand();
        }

        public string Model()
        {
            return _vehicle.Model() + "Corolla";
        }

        public double Price()
        {
            return _vehicle.Price();
        }

        public string Type()
        {
            return _vehicle.Type() + "Tres Volumenes";
        }

        public string Year()
        {
            return _vehicle.Year();
        }
    }
}
