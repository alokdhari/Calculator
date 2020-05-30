using CalculatorBL.ValidationInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public interface IUnityOfWork 
    {
        ILogger logger { get; }
        ICalculateLogic calculateLogic { get; }

        IValidate validate { get; }
    }
}
