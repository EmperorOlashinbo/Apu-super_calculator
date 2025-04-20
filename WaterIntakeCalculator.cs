using A3;
using System;

namespace A3
{
    /// <summary>
    /// Calculates daily water intake based on personal attributes.
    /// </summary>
    public class WaterIntakeCalculator
    {
        private Person person = null!; // Use null-forgiving operator to suppress warning
        private const double ML_PER_GLASS = 240.0;  // 1 glass = 240ml
        private const double OUNCES_PER_ML = 0.033814;  // 1 ml = 0.033814 oz

        // Constructor
        public WaterIntakeCalculator(Person person)
        {
            this.person = person; // Person object
        }

        /// <summary>
        /// Calculates daily water intake in milliliters based on weight.
        /// </summary>
        private double CalculateBaseIntake()
        {
            double weightKg = person.Weight; // Already in kg
            return weightKg * 33; // 33ml per kg
        }

        /// <summary>
        /// Adjusts water intake based on personal factors.
        /// </summary>
        public double CalculateDailyWaterIntakeMl()
        {
            double intake = CalculateBaseIntake(); // Base intake in ml
            int age = person.GetAge(); // Age of the person

            // Age adjustments
            if (age < 30)
                intake *= 1.1; // +10%
            else if (age > 55)
                intake *= 0.9; // -10%

            // Height adjustments
            if (person.Height > 175)
                intake *= 1.05; // +5%
            else if (person.Height < 160)
                intake *= 0.95; // -5%

            // Adjustments for Gender
            if (person.Gender == Gender.Male)
                intake *= 1.1; // +10%
            else if (person.Gender == Gender.Female)
                intake *= 0.9; // -10%

            // Adjustments for Activity Level
            switch (person.ActivityLevel)
            {
                case ActivityLevel.Medium:
                    intake *= 1.2; // +20%
                    break;
                case ActivityLevel.High:
                    intake *= 1.5; // +50%
                    break;
            }


            return intake; // Return in ml
        }

        /// <summary>
        /// Converts ml to ounces.
        /// </summary>
        public double GetWaterIntakeInOunces()
        {
            return CalculateDailyWaterIntakeMl() * OUNCES_PER_ML; // Convert ml to ounces
        }

        /// <summary>
        /// Converts water intake to the number of glasses.
        /// </summary>
        public int GetWaterIntakeInGlasses()
        {
            return (int)Math.Ceiling(CalculateDailyWaterIntakeMl() / ML_PER_GLASS); // Round up to nearest glass
        }
    }
}
