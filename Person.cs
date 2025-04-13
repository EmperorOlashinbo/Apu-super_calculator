using System;

namespace A3
{
    /// <summary>
    /// Represents a person with attributes used for health calculations.
    /// </summary>
    public class Person
    {
        // Private fields
        private double height; // in cm
        private double weight; // in kg
        private int birthYear;
        private string gender; // "Male" or "Female"
        private string activityLevel; // "Low", "Medium", or "High"

        // Constructor
        public Person(double height, double weight, int birthYear, string gender, string activityLevel)
        {
            this.height = height;
            this.weight = weight;
            this.birthYear = birthYear;
            this.gender = gender;
            this.activityLevel = activityLevel;
        }

        // Properties
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public string Gender { get => gender; set => gender = value; }
        public string ActivityLevel { get => activityLevel; set => activityLevel = value; }

        /// <summary>
        /// Calculates the person's age based on the current year.
        /// </summary>
        public int GetAge()
        {
            return DateTime.Now.Year - birthYear;
        }
    }
}
