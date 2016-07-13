using System;

namespace CALCULATOR.OneArgFunction
{
    public class Ln : IOneCalculator
    {
        /// <summary>
        /// Considers Ln
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Log(first,Math.E);
        }
    }
}