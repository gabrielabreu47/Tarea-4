using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPlatanera
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin:
            Console.WriteLine("Bienvenido a la calculadora platanera");
            Console.WriteLine("Ingrese la operacion que desea realizar:");
            Console.WriteLine(" 1 - Suma");
            Console.WriteLine(" 2 - Resta");
            Console.WriteLine(" 3 - Multiplicacion");
            Console.WriteLine(" 4 - Division");
            string valueInputed = Console.ReadLine();
            if (valueInputed == "1" || valueInputed == "2" || valueInputed == "3" || valueInputed == "4")
            {
                Console.WriteLine("Ingrese el primer numero");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                int typeOperation = Convert.ToInt32(valueInputed);
                CalculatorController calculate = new CalculatorController(typeOperation, firstNumber, secondNumber);
                Console.WriteLine(calculate.resultOfOperation().ToString());
                Console.WriteLine("Desea calcular otro numero? S/N");
                string answer = Console.ReadLine();
                if (answer == "S" || answer == "s") goto Begin;
            }
            else
            {
                Console.WriteLine("Debe seleccionar una opcion de la lista");
                Console.Read();
                goto Begin;
            }
        } 
    }
}
