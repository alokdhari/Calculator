using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL
{
    public interface ILogger
    {
        void LogResult(string probability1, string probability2, string result, string calType);
    }
}
