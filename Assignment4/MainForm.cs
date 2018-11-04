using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        Party party;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            // Clear input controls
            txtMaxNum.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;

            // Clear output controls
            lblNumGuest.Text = string.Empty;
            lblTotalCost.Text = "0.0";
            listBox.Items.Clear();

            grpInviteGuest.Enabled = false;
            grpNewParty.Enabled = true;


        }

        private bool CreateParty()
        {
            int maxNumber = 0;
            bool ok = true;

            if (int.TryParse(txtMaxNum.Text, out maxNumber) && (maxNumber > 0))
            {
                party = new Party(maxNumber);
                MessageBox.Show($"Party list with space for {maxNumber} guests created");
            }
            else
            {
                MessageBox.Show("Invalid Total Number. Please try again!", "Error");
                ok = false;
            }
            return ok;
        }

        private bool ReadCostPerPerson()
        {
            double amount = 0.0;
            bool ok = true;

            if (double.TryParse(txtAmount.Text, out amount) && (amount != 0.0))
            {
                party.CostPerCapita = amount;
            }
            else
            {
                MessageBox.Show("Invalid amount. Please try again.");
                ok = false;
            }
            return ok;
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {

            bool maxNumOk = CreateParty();
            if (!maxNumOk)
            {
                return;
            }

            bool amountOK = ReadCostPerPerson();

            if (maxNumOk && amountOK)
            {
                grpInviteGuest.Enabled = true;
                UpdateGUI();
            }
        }

        // Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TrimNames())
            {
                Console.WriteLine("SUCCESS 1");
                bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                if (!ok)
                    MessageBox.Show("List is full! New guest not added!", "Error");
            }
            else
                Console.WriteLine("ERROR 1");
                UpdateGUI();
        }

        private void UpdateGUI()
        {
            listBox.Items.Clear();

            string[] guestList = party.GetGuestList();
            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    listBox.Items.Add(str);
                }
            }
            else
            {
                return;
            }

            double totalCost = party.CalcTotalCost();
            lblTotalCost.Text = totalCost.ToString("0.00");
            lblNumGuest.Text = party.Count.ToString();

        }

        private bool ValidateText(string text)
        {
            text = text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please provide both the first and the last name", "Error");
                return false;
            }
            return true;
        }

        private void btnListBoxChange_Click(object sender, EventArgs e)
        {
            int index = IsListBoxItemSelected();

            if (index < 0)
                return;

            if (TrimNames())
            {
                party.ChangeAt(index, txtFirstName.Text, txtLastName.Text);
                UpdateGUI();
            }

        }

        private bool TrimNames()
        {
            if ((!ValidateText(txtFirstName.Text)) || (!ValidateText(txtLastName.Text)))
                return false;

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            return true;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListBoxDelete_Click(object sender, EventArgs e)
        {
            int index = IsListBoxItemSelected();
            if (index < 0)
            {
                return;
            }

            party.DeleteAt(index);
            UpdateGUI();
        }

        private int IsListBoxItemSelected()
        {
            int index = listBox.SelectedIndex;

            if (listBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select and item in the list");
                return -1;
            }
            return index;
        }

       
    }
}
