using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public class CombinedCalculator : ICalculator
    {

        /// <summary>
        /// Function to calculate Combined result.
        /// </summary>
        /// <param name="inputOne"></param>
        /// <param name="inputTwo"></param>
        /// <returns></returns>
        public double Calculate(double inputOne, double inputTwo)
        {
            return inputOne * inputTwo;
        }


        /// <summary>
        /// Function to validate input.
        /// </summary>
        /// <param name="inputOne"></param>
        /// <param name="inputTwo"></param>
        /// <returns></returns>
        public bool IsValid(double inputOne, double inputTwo)
        {
            return inputOne > 0 && inputOne <= 1 && inputTwo > 0 && inputTwo <= 1;
        }

    }
}
