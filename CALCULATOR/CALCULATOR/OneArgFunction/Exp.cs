using System;

namespace CALCULATOR.OneArgFunction
{
    public class Exp : IOneCalculator
    {
        /// <summary>
        /// Calculates the exponent
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Exp(first);
        }
    }
}