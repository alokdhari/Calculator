using CalculatorBL.ValidationInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL.ValidationLogic
{
    public class Validate : IValidate
    {
        public bool IsValidInputs(decimal prob1, decimal prob2)
        {
            if (((prob1 >= 0 && prob1 <= 1) && (prob2 >= 0 && prob2 <= 1)))
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }
    }
}
