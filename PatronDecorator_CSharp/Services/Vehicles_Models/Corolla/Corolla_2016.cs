using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Vehicles_Models.Corolla
{
    public class Corolla_2016 : VehicleDecorator_Corolla
    {
        public Corolla_2016(IVehicle vehicle) : base(vehicle)
        {

        }

        public override string CollectInformation()
        {
            string price = (this.Price() + 250000).ToString();
            string corolla2009Information = this.Brand() + " " + this.Model() + " Precio: " + price + " " + this.Year() + "2016";
            return corolla2009Information;
        }
    }
}
