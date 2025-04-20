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
        private Gender gender;
        private ActivityLevel activityLevel;

        // Constructor
        public Person(double height, double weight, int birthYear, Gender gender, ActivityLevel activityLevel)
        {
            this.height = height;
            this.weight = weight;
            this.birthYear = birthYear;
            this.gender = gender;
            this.activityLevel = activityLevel;
        }

        // Properties with controlled access
        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height must be greater than zero.");
                height = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be greater than zero.");
                weight = value;
            }
        }

        public int BirthYear
        {
            get => birthYear;
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Birth year must be a valid year.");
                birthYear = value;
            }
        }

        public Gender Gender
        {
            get => gender;
            set => gender = value;
        }

        public ActivityLevel ActivityLevel
        {
            get => activityLevel;
            set => activityLevel = value;
        }

        /// <summary>
        /// Calculates the person's age based on the current year.
        /// </summary>
        public int GetAge()
        {
            return DateTime.Now.Year - birthYear;
        }
    }

    /// <summary>
    /// Enum for gender.
    /// </summary>
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    /// <summary>
    /// Enum for activity level.
    /// </summary>
    public enum ActivityLevel
    {
        Low,
        Medium,
        High
    }
}