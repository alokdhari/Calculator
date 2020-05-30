using System;
using CalculatorBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestCalculation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Below moke repo is used when we add DI into function.
            var mokeRepo = new Mock<ICalculateLogic>();            
            mokeRepo.Setup(m => m.combined(0.2M, 0.2M)).Returns(0.4M);

            //create object for calculation class
            CalculateLogic cal = new CalculateLogic();

            //executes combined function
            var result = cal.combined(0.2M, 0.2M);
            Assert.AreEqual(0.04M, result);

        }

        [TestMethod]
        public void TestMethod2()
        {            
            //create object for calculation class
            CalculateLogic cal = new CalculateLogic();

            //executes either function
            var result2 = cal.Either(0.5M, 0.5M);
            Assert.AreEqual(0.75M, result2);

        }


    }
}
