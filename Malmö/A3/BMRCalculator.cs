using A3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    internal class BMRCalculator : BMICalculator
    {
        private int age;
        private WeeklyActivityLevel weeklyActivityLevel;
        private Gender gender;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public WeeklyActivityLevel WeeklyActivityLevel
        {
            get { return this.weeklyActivityLevel; }
            set { this.weeklyActivityLevel = value; }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public BMRCalculator() : base() { }

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

        public double CalculateWeightChangeBMR(double calorieChange)
        {
            double maintainWeightBMR = CalculateMaintainWeightBMR();
            return maintainWeightBMR + calorieChange;
        }
    }
}

