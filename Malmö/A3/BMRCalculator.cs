using A3;
using System;

namespace A3
{
    /// <summary>
    /// Represents a BMR (Basal Metabolic Rate) calculator, inheriting from BMICalculator.
    /// </summary>
    internal class BMRCalculator : BMICalculator
    {
        private int age;
        private WeeklyActivityLevel weeklyActivityLevel;
        private Gender gender;
        private double activityLevelFactor;

        /// <summary>
        /// Gets or sets the age of the person.
        /// </summary>
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        /// <summary>
        /// Gets or sets the weekly activity level of the person.
        /// </summary>
        public WeeklyActivityLevel WeeklyActivityLevel
        {
            get { return this.weeklyActivityLevel; }
            set { this.weeklyActivityLevel = value; }
        }

        /// <summary>
        /// Gets or sets the gender of the person.
        /// </summary>
        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        /// <summary>
        /// Gets or sets the activity level factor used in BMR calculations.
        /// </summary>
        public double ActivityLevelFactor
        {
            get { return this.activityLevelFactor; }
            set { this.activityLevelFactor = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BMRCalculator"/> class.
        /// </summary>
        public BMRCalculator() : base() { }

        /// <summary>
        /// Calculates the Basal Metabolic Rate (BMR) based on height, weight, age, gender, and unit type.
        /// </summary>
        /// <returns>The calculated BMR value.</returns>
        public double CalculateBMR()
        {
            double bmr;
            if (this.UnitType == UnitType.Metric)
            {
                bmr = 10 * this.Weight + 6.25 * this.Height - 5 * this.Age;
                if (this.Gender == Gender.Female)
                {
                    bmr -= 161;
                }
                else
                {
                    bmr += 5;
                }
            }
            else
            {
                bmr = 10 * this.Weight + 6.25 * this.Height - 5 * this.Age;
                if (this.Gender == Gender.Female)
                {
                    bmr -= 161;
                }
                else
                {
                    bmr += 5;
                }
            }

            return bmr;
        }

        /// <summary>
        /// Calculates the BMR required to maintain current weight based on weekly activity level.
        /// </summary>
        /// <returns>The maintain weight BMR value.</returns>
        public double CalculateMaintainWeightBMR()
        {
            double bmr = CalculateBMR();
            double multiplier;
            switch (this.WeeklyActivityLevel)
            {
                case WeeklyActivityLevel.Sedentary:
                    multiplier = 1.2;
                    break;
                case WeeklyActivityLevel.LightlyActive:
                    multiplier = 1.375;
                    break;
                case WeeklyActivityLevel.ModeratelyActive:
                    multiplier = 1.55;
                    break;
                case WeeklyActivityLevel.VeryActive:
                    multiplier = 1.725;
                    break;
                case WeeklyActivityLevel.ExtraActive:
                    multiplier = 1.9;
                    break;
                default:
                    multiplier = 1.2;
                    break;
            }
            return bmr * multiplier;
        }

        /// <summary>
        /// Calculates the BMR required for a desired weight change based on a calorie change.
        /// </summary>
        /// <param name="calorieChange">The calorie change (positive for weight gain, negative for weight loss).</param>
        /// <returns>The weight change BMR value.</returns>
        public double CalculateWeightChangeBMR(double calorieChange)
        {
            double maintainWeightBMR = CalculateMaintainWeightBMR();
            return maintainWeightBMR + calorieChange;
        }
    }
}
