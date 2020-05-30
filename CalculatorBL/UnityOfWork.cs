using CalculatorBL.Factory;
using CalculatorBL.ValidationInterface;
using CalculatorBL.ValidationLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
   public class UnityOfWork : IUnityOfWork
    {
        public UnityOfWork(string operation)
        {
            logger = new Logger();
            CalculatorFactory calculatorFactory = new CalculatorFactory();
            calculateLogic = calculatorFactory.GetOperationType(operation);
            validate = new Validate();
        }
        public ILogger logger { get; private set; }
        public ICalculateLogic calculateLogic { get; private set; }

        public IValidate validate { get; private set; }
    }
}
