using System;

namespace TaxCalculator
{
    public abstract class TaxCalculator
    {
        public static bool EnableStory4 = false;
        protected int Year { get; }

        public abstract int CalculateTax(Vehicle vehicle);

        protected TaxCalculator() : this(DateTime.Now.Year)
        {
            
        }

        protected TaxCalculator(int year)
        {
            Year = year;
        }
    }
}
