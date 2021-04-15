using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CalculatorController
    {
        private readonly int _typeOperation;
        private readonly double _firstNumber;
        private readonly double _secondNumber;

        public CalculatorController(int typeOperation, double firstNumber, double secondNumber)
        {
            _typeOperation = typeOperation;
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
        private enum operationNumber
        {
           Sum = 1,
           Rest = 2 ,
           Multiplicate = 3,
           Divide = 4
        }
        public double resultOfOperation()
        {
            switch (_typeOperation)
            {
                case (int)operationNumber.Sum:
                    return resultOfSum();
                case (int)operationNumber.Rest:
                    return resultOfRest();
                case (int)operationNumber.Multiplicate:
                    return resultOfMultiplicate();
                case (int)operationNumber.Divide:
                    return resultOfDivide();
            }
            return 0;
        }

        Operation operation;

        private double resultOfSum()
        {
            operation = CreateOperation.operation(CreateOperation.Sum);
            return operation.OperationResult(_firstNumber, _secondNumber);
        }
        private double resultOfRest()
        {
            operation = CreateOperation.operation(CreateOperation.Rest);
            return operation.OperationResult(_firstNumber, _secondNumber);
        }
        private double resultOfMultiplicate()
        {
            operation = CreateOperation.operation(CreateOperation.Multiplicate);
            return operation.OperationResult(_firstNumber, _secondNumber);
        }
        private double resultOfDivide()
        {
            operation = CreateOperation.operation(CreateOperation.Divide);
            return operation.OperationResult(_firstNumber, _secondNumber);
        }
    }
}
