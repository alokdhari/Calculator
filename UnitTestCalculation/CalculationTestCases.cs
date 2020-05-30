using System;
using CalculatorBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCalculation
{
    [TestClass]
    public class CalculationTestCases
    {
        [TestMethod]
        public void AdditionTestCase()
        {
            AdditionLogic additionLogic = new AdditionLogic();

            var result = additionLogic.Operation(0.2M, 0.2M);
            Assert.AreEqual(0.4M, result);

        }

        [TestMethod]
        public void SubstractionTestCase()
        {
            SubstractLogic substractLogic = new SubstractLogic();

            var result = substractLogic.Operation(0.2M, 0.1M);
            Assert.AreEqual(0.1M, result);

        }

        [TestMethod]
        public void MultiplyTestCase()
        {
            MultiplyLogic multiplyLogic = new MultiplyLogic();

            var result = multiplyLogic.Operation(0.2M, 0.2M);
            Assert.AreEqual(0.04M, result);

        }

        [TestMethod]
        public void DivisionTestCase()
        {
            DivisionLogic divisionLogic = new DivisionLogic();

            var result = divisionLogic.Operation(0.2M, 0.1M);
            Assert.AreEqual(0.1M, result);

        }
    }
}
