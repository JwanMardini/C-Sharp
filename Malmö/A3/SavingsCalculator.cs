using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
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
