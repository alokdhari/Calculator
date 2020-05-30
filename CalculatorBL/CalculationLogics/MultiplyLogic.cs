using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public class MultiplyLogic : ICalculateLogic
    {

        /// <summary>
        /// Function to perform combined operation.
        /// </summary>
        /// <param name="prob1"></param>
        /// <param name="prob2"></param>
        /// <returns></returns>
        public decimal Operation(decimal prob1, decimal prob2)
        {
            var calResult = prob1 * prob2;
            return calResult;
        }
    }
}
