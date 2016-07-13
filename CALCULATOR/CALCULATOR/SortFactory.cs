using System;

namespace CALCULATOR
{
    public static class SortFactory
    {
        public static ISort CreateCalculator(string sort)
        {
            switch (sort)
            {
                case "Click":
                    return new Sorter();
                default:
                    throw new Exception("I don't know this operation");
            }
        }
    }
}