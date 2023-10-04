using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            InputConverter inputconverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstNumber = inputconverter.Convert(Console.ReadLine());
            double secondNumber = inputconverter.Convert(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation , firstNumber , secondNumber );
            Console.WriteLine( result );

            } catch (Exception e)
            {
                // TODO: start loging this exception message
                Console.WriteLine( e.Message );
            }
        }
    }
}
