using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IVehicle
    {
        string Brand();
        string Model();
        string Type();
        string Year();
        double Price();

    }
}
