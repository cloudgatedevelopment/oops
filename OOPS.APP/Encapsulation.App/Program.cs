using System;

namespace Encapsulation.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var taxCalculatorInstance = new TaxCalculator();
            var njLoanAmountAfterOneYear = taxCalculatorInstance.LoanWithIntrestRate(100, "NJ", 1);
            Console.WriteLine($"Loan Amount NJ : {njLoanAmountAfterOneYear}");
            Console.ReadKey();
        }
    }
}
