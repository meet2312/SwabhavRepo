using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorExample;

namespace CalculatorExampleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       // [ExpectedException(typeof(NegativeNumberNotSupportedException))]

        public void IsNumberNegative()
        {
            //Arrange
            Calculator c = new Calculator();
            long number1 = -90;
            long number2 = 110;
            //Act
            try
            {
                long res = c.Add(-number1, number2);
               // Console.WriteLine("Addition is:{0}", res);
            }
            catch (NegativeNumberNotSupportedException e)
            {
                StringAssert.Contains(e.Message,Calculator.NegativenumberNotSupported);
                //Console.WriteLine("Exception:{0}", e.Message);
            }

           // Assert.Fail("The expected exception was not thrown.");

        }
    }
}
