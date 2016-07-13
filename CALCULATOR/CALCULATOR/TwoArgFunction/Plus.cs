namespace CALCULATOR.TwoArgFunction
{
    public class Plus:ITwoCalculator
    {
        /// <summary>
        /// Considers Plus
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }

}