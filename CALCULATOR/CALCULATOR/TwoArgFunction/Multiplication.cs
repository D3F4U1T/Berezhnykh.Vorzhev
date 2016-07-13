namespace CALCULATOR.TwoArgFunction
{
    public class Multiplication : ITwoCalculator
    {
        /// <summary>
        /// Considers Mult
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}