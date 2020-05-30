using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public interface ICalculateLogic
    {
        decimal combined(decimal prob1, decimal prob2);
        decimal Either(decimal prob1, decimal prob2);
    }
}
