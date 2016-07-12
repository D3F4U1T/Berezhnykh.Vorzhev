namespace CALCULATOR
{
    public class Multiplication : ITwoCalculator
    {
        public double Calculate(double First, double Second)
        {
            return First * Second;
        }
    }
}