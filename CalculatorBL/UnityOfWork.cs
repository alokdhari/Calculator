using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
   public class UnityOfWork : IUnityOfWork
    {
        public UnityOfWork()
        {
            logger = new Logger();
            calculateLogic = new CalculateLogic();
        }
        public ILogger logger { get; private set; }
        public ICalculateLogic calculateLogic { get; private set; }

        
    }
}
