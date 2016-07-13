namespace CALCULATOR.OneArgFunction
{
    public class Inverse : IOneCalculator
    {
        /// <summary>
        /// Inverse symbol
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Calculate(double first)
        {
            return -first;
        }
    }
}