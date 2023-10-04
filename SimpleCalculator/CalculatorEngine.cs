using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation , double firstnum , double secondnum)
        {
            double result;

            switch(operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstnum + secondnum;
                    break;
                case "subtract":
                case "-":
                    result = firstnum - secondnum;
                    break;
                case "multiply":
                case "*":
                    result = firstnum * secondnum;
                    break;
                case "divide":
                case "/":
                    result = firstnum / secondnum;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation not recognized");
            }

            return result;
        }
    }
}
