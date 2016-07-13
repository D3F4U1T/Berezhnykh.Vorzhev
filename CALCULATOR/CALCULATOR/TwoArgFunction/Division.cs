using System;

namespace CALCULATOR.TwoArgFunction
{
    public class Division : ITwoCalculator
    {
        /// <summary>
        /// Considers division
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("");
            }
            return first/second;

        }
    }
}