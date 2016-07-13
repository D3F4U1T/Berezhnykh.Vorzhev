using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Atan2 : ITwoCalculator
    {
        /// <summary>
        /// Considers Atan2
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            return Math.Atan2(first, second);
        }
    }
}