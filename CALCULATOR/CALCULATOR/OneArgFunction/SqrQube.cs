namespace CALCULATOR
{
    public class SqrQube : IOneCalculator
    {
        public double Calculate(double First)
        {
            return First*First*First;
        }
    }
}