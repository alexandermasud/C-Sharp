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

        // Creates an array with max amount of users
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

        // Get cost per person
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

        // Creates party when "Create List" is clicked, checks if inputs are valid ie more than 0
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

        // Adds person to party, "add" button
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

        // Updates the GUI after changes to the array
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

        // Validates inputs, First and Lastname may not be empty
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

        // Validates input text
        private bool TrimNames()
        {
            if ((!ValidateText(txtFirstName.Text)) || (!ValidateText(txtLastName.Text)))
                return false;

            txtFirstName.Text = txtFirstName.Text.Trim();
            txtLastName.Text = txtLastName.Text.Trim();
            return true;
        }

        // Deletes a person, checkes who is selected, deletes and updates GUI
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

        // Checks if an actual person has been selected
        private int IsListBoxItemSelected()
        {
            int index = listBox.SelectedIndex;

            if (listBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select an item in the list");
                return -1;
            }
            return index;
        }

       
    }
}
