using System;
using CalculatorBL;
using NUnit.Framework;

namespace UnitTestCalculation.CalculatorTests
{
    
    public class CalculateCombinedTests
    {
        [TestCase(1, 0.5, true)]
        [TestCase(0.5, 0.999, true)]
        [TestCase(1, 1.1, false)]
        [TestCase(1.0000000000001, 0.0000000000009, false)]
        public void ShouldBeAbleToValidate(double inputOne, double inputTwo, bool expectedResult)
        {
            // Arrange
            var service = new CombinedCalculator();

            // Action
            var result = service.IsValid(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(1, 0.5, 0.5)]
        [TestCase(1, 1, 1)]
        [TestCase(0.1, 0.1, 0.010000000000000002)]
        [TestCase(0.5, 0.999, 0.4995)]
        public void ShouldBeAbleToCalculate(double inputOne, double inputTwo, double expectedResult)
        {
            // Arrange
            var service = new CombinedCalculator();

            // Action
            var result = service.Calculate(inputOne, inputTwo);

            // Assert
            Assert.AreEqual(expectedResult, result, "The calculator logic must have been changed!");
        }
    }
}
