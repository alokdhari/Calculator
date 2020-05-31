namespace CalculatorBL
{
    public class AdditionLogic : ICalculateLogic
    {
        public decimal Operation(decimal prob1, decimal prob2)
        {
            var calResult = prob1 + prob2;
            return calResult;
        }
    }

    public class EitherCalculator : ICalculator
    {
        public double Calculate(double inputOne, double inputTwo)
        {
            return inputOne + inputTwo - (inputOne * inputTwo);
        }

        public bool IsValid(double inputOne, double inputTwo)
        {
            return inputOne > 0 && inputOne <= 1 && inputTwo > 0 && inputTwo <= 1;
        }
    }
}
