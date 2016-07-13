namespace CALCULATOR.OneArgFunction
{
    public class Sqr : IOneCalculator
    {
        /// <summary>
        /// Considers Square
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return first*first;
        }
    }
}