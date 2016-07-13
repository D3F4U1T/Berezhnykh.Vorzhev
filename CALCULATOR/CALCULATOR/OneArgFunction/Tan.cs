using System;

namespace CALCULATOR.OneArgFunction
{
    public class Tan : IOneCalculator
    {
        /// <summary>
        /// Considers tan
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}