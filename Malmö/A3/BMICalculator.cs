using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    internal class BMICalculator
    {
        private string name;
        private double height;
        private double weight;
        private UnitType unitType = UnitType.Metric;

        public BMICalculator() { }


        // getter and setter for all the fields
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public UnitType UnitType
        {
            get { return this.unitType; }
            set { this.unitType = value; }
        }

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
                // BMI with height in inches and weight in lbs'
                bmi = (this.weight / (this.height * this.height)) * 703;
                
            }
            return bmi;
        }

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

        public string DetermineNormalWeightRange()
        {
            double heightInMeters = this.height / 100;
            double lowerNormalWeight = 18.5 * heightInMeters * heightInMeters;
            double upperNormalWeight = 24.9 * heightInMeters * heightInMeters;
            return "Normal weight range " + lowerNormalWeight.ToString("0.0") + " - " + upperNormalWeight.ToString("0.0");
        }

    }

}
