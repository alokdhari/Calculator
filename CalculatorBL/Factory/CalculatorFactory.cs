using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBL.Factory
{
    public class CalculatorFactory
    {
        public ICalculateLogic GetOperationType(string operation)
        {
            ICalculateLogic calculateLogic = null;

            switch (operation)
            {
                case "Add":
                    calculateLogic = new AdditionLogic();
                    break;
                case "Substract":
                    calculateLogic = new SubstractLogic();
                    break;
                case "Multiply":
                    calculateLogic = new MultiplyLogic();
                    break;
                case "Division":
                    calculateLogic = new DivisionLogic();
                    break;


            }


            return calculateLogic;
        }
    }
}
