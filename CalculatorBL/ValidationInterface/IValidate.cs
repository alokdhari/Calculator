using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL.ValidationInterface
{
    public interface IValidate
    {
        bool IsValidInputs(decimal prob1, decimal prob2);
    }
}
