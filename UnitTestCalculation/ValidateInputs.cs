using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorBL;
using CalculatorBL.ValidationLogic;

namespace UnitTestCalculation
{
    [TestClass]
    public class ValidateInputs
    {
        [TestMethod]
        public void InputValidationTestCaseValidInput()
        {
            Validate validate = new Validate();

            var result = validate.IsValidInputs(0.1M, 0.2M);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void InputValidationTestCaseInValidInput()
        {
            Validate validate = new Validate();

            var result = validate.IsValidInputs(4.1M, 7.2M);

            Assert.AreEqual(false, result);
        }
    }
}
