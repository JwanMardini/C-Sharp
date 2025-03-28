using System;

namespace A3
{
    /// <summary>
    /// Represents a BMI (Body Mass Index) calculator.
    /// </summary>
    internal class BMICalculator
    {
        private string name;
        private double height;
        private double weight;
        private UnitType unitType = UnitType.Metric;

        /// <summary>
        /// Initializes a new instance of the <see cref="BMICalculator"/> class.
        /// </summary>
        public BMICalculator() { }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the height of the person.
        /// </summary>
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        /// <summary>
        /// Gets or sets the weight of the person.
        /// </summary>
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        /// <summary>
        /// Gets or sets the unit type used for calculations (Metric or Imperial).
        /// </summary>
        public UnitType UnitType
        {
            get { return this.unitType; }
            set { this.unitType = value; }
        }

        /// <summary>
        /// Calculates the BMI (Body Mass Index) based on height and weight.
        /// </summary>
        /// <returns>The calculated BMI value.</returns>
        public double CalculateBMI()
        {
            double bmi;
            if (this.unitType == UnitType.Metric)
            {
                // BMI with height in cm and weight in kg
                bmi = this.weight / ((this.height / 100) * (this.height / 100));
            }
            else
            {
                // BMI with height in inches and weight in lbs
                bmi = (this.weight / (this.height * this.height)) * 703;
            }
            return bmi;
        }

        /// <summary>
        /// Determines the weight category based on calculated BMI.
        /// </summary>
        /// <returns>The weight category as a string.</returns>
        public string DetermineWeightCategory()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                return "Overweight (Pre-obesity)";
            }
            else if (bmi >= 30.0 && bmi <= 34.9)
            {
                return "Overweight (Obesity class I)";
            }
            else if (bmi >= 35.0 && bmi <= 39.9)
            {
                return "Overweight (Obesity class II)";
            }
            else
            {
                return "Overweight (Obesity class III)";
            }
        }

        /// <summary>
        /// Determines the normal weight range in metric units.
        /// </summary>
        /// <returns>The normal weight range as a string.</returns>
        public string DetermineNormalWeightRangeMetric()
        {
            double heightInMeters = this.height / 100;
            double lowerNormalWeight = 18.5 * heightInMeters * heightInMeters;
            double upperNormalWeight = 24.9 * heightInMeters * heightInMeters;
            return "Normal weight range " + lowerNormalWeight.ToString("0.0") + " - " + upperNormalWeight.ToString("0.0");
        }

        /// <summary>
        /// Determines the normal weight range in imperial units.
        /// </summary>
        /// <returns>The normal weight range as a string.</returns>
        public string DetermineNormalWeightRangeImperial()
        {
            double lowerNormalWeight = 18.5 * this.height * this.height / 703;
            double upperNormalWeight = 24.9 * this.height * this.height / 703;
            return "Normal weight range " + lowerNormalWeight.ToString("0.0") + " - " + upperNormalWeight.ToString("0.0");
        }
    }
}
