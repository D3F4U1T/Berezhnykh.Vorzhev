using System;

namespace CALCULATOR.OneArgFunction
{
    public class Sin : IOneCalculator
    {
        /// <summary>
        /// Considers sin
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}