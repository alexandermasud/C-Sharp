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

        ItemManager itemManager = new ItemManager();

        public MainForm()
        {

            InitializeComponent();

            initializeGUI();
           
        }

        private void initializeGUI() {
            // fill the combobox with options

            cmbUnit.Items.AddRange(Enum.GetNames(typeof(UnitTypes)));
            cmbUnit.SelectedIndex = (int)UnitTypes.piece;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool success = false;

            ShoppingItem item = ReadInput(out success);

            if (success) {

               
                itemManager.AddItem(item);
                //UpdateGUI();
            }
        }

        private ShoppingItem ReadInput(out bool success) {
            success = false;
            ShoppingItem item = new ShoppingItem();

            // Read description
            item.Description = ReadDescription(out success);
            if (!success) {
                return null;
            }

            item.Amount = ReadAmount(out success);
            if (!success) {
                return null;
            }

            item.Unit = ReadUnit(out success);

            return item;

        }

        private double ReadAmount(out bool success) {
            double amount = 0.0;
            success = false;

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


        private string ReadDescription(out bool success) {
            string description = "";
            success = false;


            if (txtDescription.Text.Equals (string.Empty))
            {
                GiveMessage("Invalid description");
                txtDescription.Focus();

            }
            else {
                success = true;
            }

            return description;

        }


        private UnitTypes ReadUnit(out bool success) {

            UnitTypes unit = UnitTypes.cm;
            success = false;

            if (cmbUnit.Text.Equals(string.Empty))
            {
                GiveMessage("Invalid unit");
                cmbUnit.Focus();
            }
            else {
                success = true;
            }

            return unit;
        }

        private void GiveMessage(string message) {

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 

        }
    }
}