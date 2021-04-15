using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Operation
    {
        public abstract double OperationResult(double firstNumber, double secondNumber);
    }
}
