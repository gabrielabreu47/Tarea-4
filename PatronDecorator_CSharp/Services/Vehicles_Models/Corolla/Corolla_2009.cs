using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Vehicles_Models.Corolla
{
    public class Corolla_2009 : VehicleDecorator_Corolla
    {
        public Corolla_2009(IVehicle vehicle) : base(vehicle)
        {
            
        }
        public override string CollectInformation()
        {
            string price = (this.Price() - 25000).ToString();
            string corolla2009Information = this.Brand() + " " + this.Model() + " Precio: " + price + " " + this.Year() + "2009 " + this.Type();
            return corolla2009Information;
        }
    }
}
