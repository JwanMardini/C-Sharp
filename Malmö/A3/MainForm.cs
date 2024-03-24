using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalculator = new BMICalculator();
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

        private void UpdateHeightText()
        {
            if(rbtnimperial.Checked)
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
            if(rbtnimperial.Checked)
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


        private void rbtnimperial_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHeightText();
            UpdateWeightText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadInputBMI();

            double bmi = bmiCalculator.CalculateBMI();
            txtBMI.Text = bmi.ToString("0.00");

            string weightCategory = bmiCalculator.DetermineWeightCategory();
            weightCat.Text = weightCategory;

            string normalWeight = bmiCalculator.DetermineNormalWeightRange();
            norText.Text = normalWeight;
        }

        private void ReadInputBMI()
        {
            ReadName();
            ReadHight();
            ReadWeight();
            ReadUnitType();
        }

        private void ReadUnitType()
        {
            if (rbtnmetric.Checked)
            {
                bmiCalculator.UnitType = UnitType.Metric;
            }
            else
            {
                bmiCalculator.UnitType = UnitType.Imperial;
            }
        }


        private void ReadHight()
        {
            double height = ReadDouble(txtheight.Text, out bool success);
            if (!success)
            {
                MessageBox.Show("Invalid height value");
                return;
            }
            if (rbtnimperial.Checked)
            {
                double height2 = ReadDouble(txtheight2.Text, out success);
                if (!success)
                {
                    MessageBox.Show("Invalid height value");
                    return;
                }
                height = height * 12 + height2;
            }
            bmiCalculator.Height = height;
        }

        private void ReadWeight()
        {
            double weight = ReadDouble(txtweight.Text, out bool success);
            if (!success)
            {
                MessageBox.Show("Invalid weight value");
                return;
            }
            bmiCalculator.Weight = weight;
        }


        private void ReadName()
        {
            txtname.Text.Trim();
            if (!string.IsNullOrEmpty(txtname.Text))
            {
                bmiCalculator.Name = txtname.Text;
            }
            else
            {
                bmiCalculator.Name = "Unknown";
            }

        }

        private double ReadDouble(string str, out bool success)
        {
            double value;
            success = false;
            if(double.TryParse(str.Trim(), out value))
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

        private void calculate_saving_Click(object sender, EventArgs e)
        {
            ReadInputSavings();

            (double amountPaid, double amountEarned, double finalBalance, double totalFees) = savingsCalculator.CalculateFutureValue();
            amountpaid.Text = amountPaid.ToString("0.00");
            amountearned.Text = amountEarned.ToString("0.00");
            finalbalance.Text = finalBalance.ToString("0.00");
            totalfees.Text = totalFees.ToString("0.00");

        }

        private void ReadInputSavings()
        {
            double initDeposit = ReadDouble(initDep.Text, out bool success);
            if (!success)
            {
                MessageBox.Show("Invalid initial deposit value");
                return;
            }

            double monthlySaving = ReadInt(Months.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid monthly saving value");
                return;
            }

            int years = ReadInt(period.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid period value");
                return;
            }

            double annualInterestRate = ReadDouble(growth.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid annual interest rate value");
                return;
            }

            double feesRate = ReadDouble(fees.Text, out success);
            if (!success)
            {
                MessageBox.Show("Invalid fees rate value");
                return;
            }

            savingsCalculator = new SavingsCalculator(initDeposit, monthlySaving, annualInterestRate, feesRate, years);

        }
    }

}
