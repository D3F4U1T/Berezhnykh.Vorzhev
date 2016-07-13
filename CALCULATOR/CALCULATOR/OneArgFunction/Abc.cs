using System;

namespace CALCULATOR.OneArgFunction
{
    public class Abc : IOneCalculator
    {
        /// <summary>
        /// Considers module
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}