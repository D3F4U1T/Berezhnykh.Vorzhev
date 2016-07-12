namespace CALCULATOR.OneArgFunction
{
    public class SqrQube : IOneCalculator
    {
        public double Calculate(double first)
        {
            return first*first*first;
        }
    }
}