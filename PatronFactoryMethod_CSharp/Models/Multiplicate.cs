using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Multiplicate : Operation
    {
        public override double OperationResult(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
