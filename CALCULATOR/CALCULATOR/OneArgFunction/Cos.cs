using System;

namespace CALCULATOR.OneArgFunction
{
    public class Cos : IOneCalculator
    {
        /// <summary>
        /// Considers cos
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}