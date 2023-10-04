using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System;

namespace simpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {

        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number = 0;
            int number2 = 2;
            double number3 = _calculatorEngine.Calculate("add" , number , number2) ;  
            
            Assert.AreEqual(2, number3);
        }


        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number = 0;
            int number2 = 2;
            double number3 = _calculatorEngine.Calculate("+", number, number2);

            Assert.AreEqual(2, number3);
        }
    }
}
