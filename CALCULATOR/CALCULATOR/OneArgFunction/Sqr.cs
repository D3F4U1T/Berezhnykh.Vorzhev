namespace CALCULATOR.OneArgFunction
{
    public class Sqr : IOneCalculator
    {
        public double Calculate(double first)
        {
            return first*first;
        }
    }
}