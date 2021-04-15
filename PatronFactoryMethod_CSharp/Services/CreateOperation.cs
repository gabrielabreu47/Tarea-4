using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CreateOperation
    {
        public const int Sum = 1;
        public const int Rest = 2;
        public const int Multiplicate = 3;
        public const int Divide = 4;

        public static Operation operation(int typeOperation)
        {
            switch (typeOperation)
            {
                case Sum:
                    return new Sum();
                case Rest:
                    return new Rest();
                case Multiplicate:
                    return new Multiplicate();
                case Divide:
                    return new Divide();
                default:
                    return null;
            }
        }
    }
}
