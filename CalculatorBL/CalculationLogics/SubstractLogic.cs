using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public class SubstractLogic : ICalculateLogic
    {
        public decimal Operation(decimal prob1, decimal prob2)
        {
            var calResult = prob1 - prob2;
            return calResult;
        }
    }
}
