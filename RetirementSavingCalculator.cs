using A3;
using System;

namespace A3
{
    /// <summary>
    /// Calculates future retirement savings based on user input.
    /// </summary>
    public class RetirementSavingCalculator
    {
        private Person person;
        private double initialSavings;
        private double monthlyContribution;
        private double annualInterestRate;
        private int retirementAge;

        // Constructor
        public RetirementSavingCalculator(Person person, double initialSavings, double monthlyContribution, double annualInterestRate, int retirementAge)
        {
            this.person = person; // Person object
            this.initialSavings = initialSavings; // Initial savings amount
            this.monthlyContribution = monthlyContribution; // Monthly contribution amount
            this.annualInterestRate = annualInterestRate / 100; // Convert to decimal
            this.retirementAge = retirementAge; // Age at retirement
        }

        /// <summary>
        /// Calculates the total savings at retirement using the compound interest formula.
        /// </summary>
        public double CalculateFutureSavings()
        {
            int currentAge = person.GetAge(); // Current age of the person
            int yearsToRetirement = retirementAge - currentAge; // Years until retirement

            if (yearsToRetirement <= 0) // Retirement age must be greater than current age
            {
                Console.WriteLine("Error: Retirement age must be greater than current age.");
                return initialSavings; // Return initial savings amount
            }

            int n = 12; // Monthly compounding
            double r = annualInterestRate; // Already converted to decimal
            int t = yearsToRetirement; // Time in years

            // Future value of initial savings
            double futureValueOfInitial = initialSavings * Math.Pow(1 + (r / n), n * t);

            // Future value of monthly contributions (annuity formula)
            double futureValueOfContributions = monthlyContribution * ((Math.Pow(1 + (r / n), n * t) - 1) / (r / n));

            return futureValueOfInitial + futureValueOfContributions; // Total future savings
        }

        /// <summary>
        /// Calculates the total interest earned at retirement.
        /// </summary>
        public double CalculateTotalInterest()
        {
            double futureSavings = CalculateFutureSavings(); // Total savings at retirement
            double totalInvestment = initialSavings + (monthlyContribution * 12 * (retirementAge - person.GetAge())); // Total investment
            return futureSavings - totalInvestment; // Total interest earned
        }
    }
}
