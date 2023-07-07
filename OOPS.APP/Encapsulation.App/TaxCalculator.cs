namespace Encapsulation.App
{
    /// <summary>
    ///  Encapsulation, is to make sure that "sensitive" data is hidden from users
    /// </summary>
    public class TaxCalculator
    {
        private readonly double NJ = 6.5;
        private readonly double NY = 10;
        // Write Code Here

        public double LoanWithIntrestRate(double amount, string state, int years)
        {
            double result = 0;
            switch (state)
            {
                case "NJ":
                    result = amount + SimpleIntrest(amount, NJ, years);
                    break;
                case "NY":
                    result = amount + SimpleIntrest(amount, NY, years);
                    break;
                    // Write Code Here
            }
            return result;
        }

        public double SimpleIntrest(double principal, double intrestRate, int years)
        {
            return principal * intrestRate * years / 100;
        }

    }
}
