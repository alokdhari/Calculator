namespace CalculatorBL
{
    public interface ICalculator
    {
        bool IsValid(double inputOne, double inputTwo);

        double Calculate(double inputOne, double inputTwo);
    }
}
