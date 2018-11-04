using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private BMICalculator bmiCalc = new BMICalculator();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI ()
        {
            this.Text = "The Body Mass Calculator";

            // input
            rbtnUsUnit.Checked = true;
            lblHeight.Text = "Height (feet)";
            lblWeight.Text = "Weight (lbs)";

            // output
            txtWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
        }


        // Calculate button
        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = ReadInputBMI();

            if (ok)
            {
                // Calculates and displays result
                DisplayResults();
            }
        }

        private bool ReadInputBMI()
        {
            bool isInputOk = false;

            ReadName();
            ReadUnitType();
            isInputOk = ReadHeight();
            isInputOk = isInputOk && ReadWeight();

            return isInputOk;
        }

        private void ReadUnitType()
        {
            if (rbtnMetric.Checked)
                bmiCalc.SetUnit(UnitTypes.Metric);
            else
                bmiCalc.SetUnit(UnitTypes.American);
        }


        private void ReadName()
        {
            txtName.Text.Trim();

            if (!string.IsNullOrEmpty(txtName.Text))
                bmiCalc.SetName(txtName.Text);
            else
                bmiCalc.SetName("Unknown");
        }

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

        private void DisplayResults ()
        {
            lblResultsYourBmi.Text = bmiCalc.CalculateBMI().ToString("f2");
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblResultsYourBmi_Click(object sender, EventArgs e)
        {

        }
    }
}
