using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Sqrtx : ITwoCalculator
    {
        /// <summary>
        /// Considers sqrt (x)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, 1/second);
        }
    }
}