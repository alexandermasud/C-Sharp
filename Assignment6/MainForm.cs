using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class MainForm : Form
    {
        TaskManager taskManager = new TaskManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        // Clears PriorityBox and set Normal as default, sets tooltip on dateTimePicker, desabled File/open and File/close
        private void InitializeGUI() {

            cmbBox.Items.Clear();
            string[] priority = Enum.GetNames(typeof(PriorityType));
            foreach (var item in priority) cmbBox.Items.Add(item.Replace("_", " "));
            cmbBox.SelectedIndex = (int)PriorityType.Normal;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(dateTimePicker, "Click to open calendar");
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd  HH:mm";

            openDatafileToolStripMenuItem.Enabled = false;
            closeDatafileToolStripMenuItem.Enabled = false;
        }

        // The add button on the form
        private void bntAdd_Click(object sender, EventArgs e)
        {
            bool success = false;

            Task item = ReadInput(out success);

            if (success) {
                
                taskManager.AddItem(item);
                UpdateGUI();
            }
        }

        // Calls on the Date and time, Description and Priority 
        private Task ReadInput(out bool success)
        {
            success = false;
            Task item = new Task();

            item.DateAndTime = ReadDateAndTime(out success);
            
            if (!success) {
                return null;
            }

            item.Description = ReadDescription(out success);
                if (!success) {
                return null;
            }

            item.Priority = ReadPriority(out success);
                return item;
        }

        // Returns the date and time
        private DateTime ReadDateAndTime(out bool success) {
            DateTime dateAndTime = default(DateTime);
            success = false;

            if (dateTimePicker.Text.Equals(string.Empty))
            {
                GiveMessage("Invalid Date and Time");
                dateTimePicker.Focus();
            }
            else {
                dateAndTime = dateTimePicker.Value;
                
                success = true;
            }
            return dateAndTime;
        }

        // Returns the description
        private string ReadDescription(out bool success) {
            string description = "";
            success = false;

            if (textBox1.Text.Equals(string.Empty))
            {
                GiveMessage("Invalid description");
                textBox1.Focus();
            }
            else {
                description = textBox1.Text;
                success = true;
            }
            return description;
        }

        // Returns priority
        private PriorityType ReadPriority (out bool success) {

            PriorityType priority = PriorityType.Less_important;

            success = false;


            if (cmbBox.Text.Equals(string.Empty))
            {
                GiveMessage("Invalid Priority");
                cmbBox.Focus();
            }
            else {

                // Less important and More important has space, but Enum PriorityType has underscore _ which need to be controlled for
                string checkForSpace = cmbBox.Text;
                bool hasSpace = checkForSpace.Contains(" ");


                if (hasSpace)
                {
                    checkForSpace = checkForSpace.Replace(" ", "_");
                    priority = (PriorityType)Enum.Parse(typeof(PriorityType), checkForSpace);
                }
                else {
                    priority = (PriorityType)Enum.Parse(typeof(PriorityType), cmbBox.Text);
                }
                
                success = true;
            }

            return priority;
        }

        // Shows messagebox with error message
        private void GiveMessage(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Updates GUI after new task has been added
        // Listbox not aligning correctly, out of my control. Aligns perfect in Console.WriteLine(tempString) row 166 and 170. 
        // What happens inside of listBox1.Items.Add is out of my control
        private void UpdateGUI() {
            dateTimePicker.Value = DateTime.Now;
            cmbBox.SelectedIndex = (int)PriorityType.Normal;
            listBox1.Items.Clear();
            textBox1.Clear();


            string tempString = "";
            
            for (int i = 0; i < taskManager.Count; i++)
            {
                tempString = taskManager.GetItem(i).ToString();

                if (tempString.Contains("_"))
                {
                    tempString = tempString.Replace("_", " ");
                    listBox1.Items.Add(tempString);
                    Console.WriteLine(tempString);
                }
                else {
                    listBox1.Items.Add(tempString);
                    Console.WriteLine(tempString);
                }
            }
        }

        // The bottom right timer 
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        // File/exit
        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Avsluta?", "Important Query", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                Close();
            }
        }

        // Help/About
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();

        }

        // Key shortcuts
        private void MainForm_KeyDown(object sender, KeyEventArgs e) {

            if ((e.Control && e.KeyCode == Keys.N)) {
                InitializeGUI();
            }
            else if ((e.Alt && e.KeyCode == Keys.F4)) {
                DialogResult result = MessageBox.Show("Avsluta?", "Important Query", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    Close();
                }
            }
        }
    }
}
