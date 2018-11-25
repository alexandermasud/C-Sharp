using System;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        // Inits BMICalculator object
        private BMICalculator bmiCalc = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();

            // Sets GUI to metric/kg
            InitializeGUI();
        }

        private void InitializeGUI ()
        {
            this.Text = "The Body Mass Calculator";

            // Sets cm/kg
            rbtnMetric.Checked = true;
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";

            // Clears input values
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
        }


        // Calculate button
        private void button1_Click(object sender, EventArgs e)
        {   
            bool ok = ReadInputBMI();

            if (ok)
            {
                DisplayResults();
            }
        }

        // Reads input values
        private bool ReadInputBMI()
        {
            bool isInputOk = false;

           
            ReadName();
            ReadUnitType();
            isInputOk = ReadHeight();
            isInputOk = isInputOk && ReadWeight();

            return isInputOk;
        }

        // (cm/kg) or (feet, lbs)
        private void ReadUnitType()
        {
            if (rbtnMetric.Checked)
                bmiCalc.SetUnit(UnitTypes.Metric);
            else
                bmiCalc.SetUnit(UnitTypes.American);
        }

        // Reads username
        private void ReadName()
        {
            txtName.Text.Trim();

            if (!string.IsNullOrEmpty(txtName.Text))
                bmiCalc.SetName(txtName.Text);
            else
                bmiCalc.SetName("Unknown");
        }

        // Reads the height
        private bool ReadHeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtHeight.Text, out outValue);
            if(ok)
            {
                if(outValue > 0)
                {
                    if(bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        // feet to inches
                        bmiCalc.SetHeight(outValue * 12.00); 
                    }
                    else
                    {
                        // cm to m
                        bmiCalc.SetHeight(outValue / 100.00);
                    }
                }
                else
                {
                    ok = false;
                }
            }
            if(!ok)
            {
                MessageBox.Show("Invalid height value", "Error");
            }

            return ok;
        }

        // Reads the weight
        private bool ReadWeight()
        {
            double outValue = 0;
            bool ok = double.TryParse(txtWeight.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    if (bmiCalc.GetUnit() == UnitTypes.American)
                    {
                        // sets weight in ibs
                        bmiCalc.SetWeight(outValue);
                    }
                    else
                    {
                        //sets weight in kg
                        bmiCalc.SetWeight(outValue);
                    }
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                MessageBox.Show("Invalid weight value", "Error");
            }

            return ok;
        }

        // Calculates and displays the result
        private void DisplayResults ()
        {

            double bmi = bmiCalc.CalculateBMI();
            lblResultsYourBmi.Text = bmiCalc.CalculateBMI().ToString("f2");

            if (bmi > 40) {
                lblCategory.Text = "Class 3 Obesity";
            }
            else if (bmi >= 35)
            {
                lblCategory.Text = "Class 2 Obesity";
            }
            else if (bmi >= 30) {
                lblCategory.Text = "Class 1 Obesity";
            }
            else if (bmi >= 25) {
                lblCategory.Text = "Overweight";
            }
            else if (bmi >= 18.5)
            {
                lblCategory.Text = "Normal";
            }
            else
            {
                lblCategory.Text = "Underweight";
            }

            grpResults.Text = "Results for " + bmiCalc.GetName();
        }

        // Clears input fields when change unit to Metric
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
        }

        // Clears input fields when change unit to US
        private void rbtnUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
        }

        
    }
}
