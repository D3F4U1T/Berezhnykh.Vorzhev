using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Sqrxy : ITwoCalculator
    {
        /// <summary>
        /// Considers sqr
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}