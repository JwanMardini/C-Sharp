using System;

namespace A3
{
    /// <summary>
    /// Represents a savings calculator that calculates future value based on initial deposit, monthly savings, growth rate, and fees rate.
    /// </summary>
    internal class SavingsCalculator
    {
        private readonly double initialDeposit;
        private readonly double monthlySavings;
        private readonly double growthRate;
        private readonly double feesRate;
        private readonly int years;
        private readonly int months;
        private readonly double monthlyGrowthRate;
        private readonly double monthlyFeesRate;

        /// <summary>
        /// Initializes a new instance of the <see cref="SavingsCalculator"/> class.
        /// </summary>
        /// <param name="initialDeposit">The initial deposit amount.</param>
        /// <param name="monthlySavings">The monthly savings amount.</param>
        /// <param name="growthRate">The annual growth rate in percentage (e.g., 5 for 5%).</param>
        /// <param name="feesRate">The annual fees rate in percentage (e.g., 1 for 1%).</param>
        /// <param name="years">The number of years to calculate.</param>
        public SavingsCalculator(double initialDeposit, double monthlySavings, double growthRate, double feesRate, int years)
        {
            this.initialDeposit = initialDeposit;
            this.monthlySavings = monthlySavings;
            this.growthRate = growthRate / 100.0; // Convert percentage to decimal
            this.feesRate = feesRate / 100.0; // Convert percentage to decimal
            this.years = years;
            this.months = years * 12;
            this.monthlyGrowthRate = this.growthRate / 12.0;
            this.monthlyFeesRate = this.feesRate / 12.0;
        }

        /// <summary>
        /// Calculates the future value of savings including amount paid, amount earned, final balance, and total fees.
        /// </summary>
        /// <returns>A tuple containing the amount paid, amount earned, final balance, and total fees.</returns>
        public (double AmountPaid, double AmountEarned, double FinalBalance, double TotalFees) CalculateFutureValue()
        {
            double balance = initialDeposit;
            double totalInterest = 0;
            double totalFees = 0;

            for (int month = 1; month <= months; month++)
            {
                double interest = balance * monthlyGrowthRate;
                double fees = balance * monthlyFeesRate;
                balance += interest - fees + monthlySavings;
                totalInterest += interest;
                totalFees += fees;
            }

            double amountPaid = initialDeposit + (months * monthlySavings);
            double amountEarned = totalInterest;
            double finalBalance = balance;

            return (amountPaid, amountEarned, finalBalance, totalFees);
        }
    }
}
