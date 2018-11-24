using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class MainForm : Form
    {

        // Itltialize itemManager object
        ItemManager itemManager = new ItemManager();

        public MainForm()
        {

            InitializeComponent();
            initializeGUI();
           
        }

        private void initializeGUI() {
            // fill the combobox with options and starts with piece as default unit

            cmbUnit.Items.AddRange(Enum.GetNames(typeof(UnitTypes)));
            cmbUnit.SelectedIndex = (int)UnitTypes.piece;
        }

        // When use clickes add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = false;

            // Reads input from form
            ShoppingItem item = ReadInput(out success);

            if (success) {

                // If inputs are valid, item is added to itemanager and GUI updated
                itemManager.AddItem(item);
                UpdateGUI();
            }
        }

        // Reads input from form
        private ShoppingItem ReadInput(out bool success) {
            success = false;

            // Creates new item object
            ShoppingItem item = new ShoppingItem();

            // Reads description 
            item.Description = ReadDescription(out success);
            if (!success) {
                return null;
            }

            // Reads amount
            item.Amount = ReadAmount(out success);
            if (!success) {
                return null;
            }

            // Reads unit
            item.Unit = ReadUnit(out success);
            return item;
        }

        // Reads amount
        private double ReadAmount(out bool success) {
            double amount = 0.0;
            success = false;

            // Checks if value given is valid double value
            if (!double.TryParse(txtAmount.Text, out amount))
            {
                GiveMessage("Wrong amount!");
                // Highlight the text
                txtAmount.Focus();
                txtAmount.SelectionStart = 0;
                txtAmount.SelectionLength = txtAmount.TextLength;
            }
            else {
                success = true;
            }

            return amount;
        }

        // Reads description
        private string ReadDescription(out bool success) {
            string description = "";
            success = false;

            // Checks if the description is empty
            if (txtDescription.Text.Equals (string.Empty))
            {
                GiveMessage("Invalid description");
                txtDescription.Focus();

            }
            else {
                description = txtDescription.Text;
                success = true;
            }

            return description;
        }

        // Reads unit 
        private UnitTypes ReadUnit(out bool success) {

            UnitTypes unit = UnitTypes.piece;
            success = false;

            // Checks if choosen unit is empty
            if (cmbUnit.Text.Equals(string.Empty))
            {
                GiveMessage("Invalid unit");
                cmbUnit.Focus();
            }
            else {
                // Takes selected unit value and returns it
                unit = (UnitTypes)Enum.Parse(typeof(UnitTypes), cmbUnit.Text);
                success = true;
            }

            return unit;
        }

        // Shows error message for fields if they are invalid
        private void GiveMessage(string message) {

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 

        }

        // updates GUI with new value and empties input fields
        private void UpdateGUI() {

            txtAmount.Clear();
            txtDescription.Clear();
            cmbUnit.SelectedIndex = (int)UnitTypes.piece;
            lstItems.Items.Clear();

            for (int i = 0; i < itemManager.Count; i++)
            {
                lstItems.Items.Add(itemManager.GetItem(i).ToString());
            }

        }
    }
}