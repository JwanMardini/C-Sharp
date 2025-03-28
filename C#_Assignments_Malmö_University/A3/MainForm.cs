using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    public partial class MainForm : Form
    {
        private BMRCalculator BmiAndBmrCalulater = new BMRCalculator();
        private SavingsCalculator savingsCalculator;


        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // clear the textboxes
            txtname.Text = "";
            txtweight.Text = "";
            txtheight.Text = "";
            txtheight2.Text = "";
            norText.Text = "";
            weightCat.Text = "";
            txtBMI.Text = "";
            amountpaid.Text = "";
            amountearned.Text = "";
            finalbalance.Text = "";
            totalfees.Text = "";

            rbtnmetric.Checked = true;
            UpdateHeightText();
            UpdateWeightText();
        }

        private void calculate_bmibtn_Click(object sender, EventArgs e)
        {
            bool inputs = ReadInputBMI();
            if (!inputs)
            {
                return;
            }

            double bmi = BmiAndBmrCalulater.CalculateBMI();
            txtBMI.Text = bmi.ToString("0.00");

            string weightCategory = BmiAndBmrCalulater.DetermineWeightCategory();
            weightCat.Text = weightCategory;

            if (rbtnmetric.Checked)
            {
                string output = BmiAndBmrCalulater.DetermineNormalWeightRangeMetric();
                norText.Text = output;
            }
            else
            {
                string output = BmiAndBmrCalulater.DetermineNormalWeightRangeImperial();
                norText.Text = output;
            }

        }


        private void rbtnimperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
            UpdateWeightText();
        }


        private void calculate_saving_Click(object sender, EventArgs e)
        {
            bool inputs = InputSavings();
            if (!inputs)
            {
                return;
            }

            (double amountPaid, double amountEarned, double finalBalance, double totalFees) = savingsCalculator.CalculateFutureValue();
            amountpaid.Text = amountPaid.ToString("0.00");
            amountearned.Text = amountEarned.ToString("0.00");
            finalbalance.Text = finalBalance.ToString("0.00");
            totalfees.Text = totalFees.ToString("0.00");

        }

        private void calculate_bmrbtn_Click(object sender, EventArgs e)
        {
            bool inputs = ReadInputBMR();
            if (!inputs)
            {
                return;
            }

            double bmr = BmiAndBmrCalulater.CalculateBMR();
            double caloriesToMaintainWeight = bmr * BmiAndBmrCalulater.ActivityLevelFactor;
            double caloriesToLose05Kg = caloriesToMaintainWeight - 500;
            double caloriesToLose1Kg = caloriesToMaintainWeight - 1000;
            double caloriesToGain05Kg = caloriesToMaintainWeight + 500;
            double caloriesToGain1Kg = caloriesToMaintainWeight + 1000;

            string output = "BMR RESULTS FOR " + BmiAndBmrCalulater.Name.ToUpper() + "\n";
            output += "Your BMR (calories/day)              " + bmr.ToString("0.0") + "\n";
            output += "Calories to maintain your weight     " + caloriesToMaintainWeight.ToString("0.0") + "\n";
            output += "Calories to lose 0,5 kg per week     " + caloriesToLose05Kg.ToString("0.0") + "\n";
            output += "Calories to lose 1 kg per week       " + caloriesToLose1Kg.ToString("0.0") + "\n";
            output += "Calories to gain 0,5 kg per week     " + caloriesToGain05Kg.ToString("0.0") + "\n";
            output += "Calories to gain 1 kg per week       " + caloriesToGain1Kg.ToString("0.0") + "\n";

            if (caloriesToLose1Kg < 1000)
            {
                output += "Losing more than 1000 calories per day is not recommended.";
            }

            bmrresult.Text = output;
        }

        private bool ReadInputBMR()
        {
            ReadName();
            bool readHeight = ReadHight();
            if (!readHeight)
            {
                return false;
            }
            bool readWeight = ReadWeight();
            if (!readWeight)
            {
                return false;
            }
            bool readAge = ReadAge();
            if (!readAge)
            {
                return false;
            }
            bool readGender = ReadGender();
            if (!readGender)
            {
                return false;
            }
            bool readWeeklyActivityLevel = ReadWeeklyActivityLevel();
            if (!readWeeklyActivityLevel)
            {
                return false;
            }
            return true;
        }

        private bool ReadInputBMI()
        {
            ReadName();
            bool readHeight = ReadHight();
            if (!readHeight)
            {
                return false;
            }
            bool readWeight = ReadWeight();
            if (!readWeight)
            {
                return false;
            }
            ReadUnitType();
            return true;
        }

        private void ReadUnitType()
        {
            if (rbtnmetric.Checked)
            {
                BmiAndBmrCalulater.UnitType = UnitType.Metric;
            }
            else
            {
                BmiAndBmrCalulater.UnitType = UnitType.Imperial;
            }
        }

        private bool ReadGender()
        {
            if (femalerbtn.Checked)
            {
                BmiAndBmrCalulater.Gender = Gender.Female;
                return true;
            }
            else if (malerbtn.Checked)
            {
                BmiAndBmrCalulater.Gender = Gender.Male;
                return true;
            }
            else
            {
                MessageBox.Show("Please select a gender");
                return false;
            }

        }

        private bool ReadWeeklyActivityLevel()
        {
            if (rbtnsedentary.Checked)
            {
                ((BMRCalculator)BmiAndBmrCalulater).WeeklyActivityLevel = WeeklyActivityLevel.Sedentary;
                BmiAndBmrCalulater.ActivityLevelFactor = 1.2;
                return true;
            }
            else if (rbtnlight.Checked)
            {
                ((BMRCalculator)BmiAndBmrCalulater).WeeklyActivityLevel = WeeklyActivityLevel.LightlyActive;
                BmiAndBmrCalulater.ActivityLevelFactor = 1.375;
                return true;
            }
            else if (rbtnmoderate.Checked)
            {
                ((BMRCalculator)BmiAndBmrCalulater).WeeklyActivityLevel = WeeklyActivityLevel.ModeratelyActive;
                BmiAndBmrCalulater.ActivityLevelFactor = 1.550;
                return true;
            }
            else if (rbtnactive.Checked)
            {
                ((BMRCalculator)BmiAndBmrCalulater).WeeklyActivityLevel = WeeklyActivityLevel.VeryActive;
                BmiAndBmrCalulater.ActivityLevelFactor = 1.725;
                return true;
            }
            else if (rbtnveryactive.Checked)
            {
                ((BMRCalculator)BmiAndBmrCalulater).WeeklyActivityLevel = WeeklyActivityLevel.ExtraActive;
                BmiAndBmrCalulater.ActivityLevelFactor = 1.9;
                return true;
            }
            else
            {
                MessageBox.Show("Please select a weekly activity level");
                return false;
            }
        }

        private bool ReadHight()
        {
            double height = ReadDouble(txtheight.Text, out bool success);
            if (!success)
            {
                MessageBox.Show("Invalid height value");
                return false;
            }
            if (rbtnimperial.Checked)
            {
                double height2 = ReadDouble(txtheight2.Text, out success);
                if (!success)
                {
                    MessageBox.Show("Invalid height value");
                    return false;
                }
                height = height * 12 + height2;
            }
            BmiAndBmrCalulater.Height = height;
            return true;
        }

        private bool ReadWeight()
        {
            double weight = ReadDouble(txtweight.Text, out bool success);
            if (!success)
            {
                MessageBox.Show("Invalid weight value");
                return false;
            }
            BmiAndBmrCalulater.Weight = weight;
            return true;
        }


        private void ReadName()
        {
            txtname.Text.Trim();
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                BmiAndBmrCalulater.Name = txtname.Text;
            }
            else
            {
                BmiAndBmrCalulater.Name = "Unknown";
            }

        }

        private bool ReadAge()
        {
            int age = ReadInt(txtage.Text, out bool success);
            if (!success)
            {
                MessageBox.Show("Invalid age value");
                return false;
            }
            ((BMRCalculator)BmiAndBmrCalulater).Age = age;
            return true;
        }

        private bool InputSavings()
        {
            double initDeposit = ReadDouble(initDep.Text, out bool success);
            if (!success)
            {
                MessageBox.Show("Invalid initial deposit value");
                return false;
            }

            double monthlySaving = ReadInt(Months.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid monthly saving value");
                return false;
            }

            int years = ReadInt(period.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid period value");
                return false;
            }

            double annualInterestRate = ReadDouble(growth.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid annual interest rate value");
                return false;
            }

            double feesRate = ReadDouble(fees.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid fees rate value");
                return false;
            }

            savingsCalculator = new SavingsCalculator(initDeposit, monthlySaving, annualInterestRate, feesRate, years);
            return true;
        }

        

        private double ReadDouble(string str, out bool success)
        {
            double value;
            success = false;
            if (double.TryParse(str.Trim(), out value))
            {
                success = true;
            }
            return value;
        }

        private int ReadInt(string str, out bool success)
        {
            int value;
            success = false;
            if (int.TryParse(str.Trim(), out value))
            {
                success = true;
            }
            return value;
        }

        private void UpdateHeightText()
        {
            if (rbtnimperial.Checked)
            {
                lblheight.Text = "Height (in, ft)";
            }
            else
            {
                lblheight.Text = "Height (cm)";
            }
        }

        private void UpdateWeightText()
        {
            if (rbtnimperial.Checked)
            {
                lblweight.Text = "Weight (lb)";
                ftlbl.Visible = true;
                inlbl.Visible = true;
                txtheight2.Visible = true;
            }
            else
            {
                lblweight.Text = "Weight (kg)";
                ftlbl.Visible = false;
                inlbl.Visible = false;
                txtheight2.Visible = false;
            }
        }


    }

}
