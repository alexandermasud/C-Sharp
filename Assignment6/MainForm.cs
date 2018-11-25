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

        private void InitializeGUI() {

            //cmbBox.Items.Clear();
            //string[] priority = Enum.GetNames(typeof(PriorityType));
            //foreach (var item in priority) cmbBox.Items.Add(item.Replace("_", " "));
            cmbBox.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            cmbBox.SelectedIndex = (int)PriorityType.Normal;

            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(dateTimePicker, "Click to open calendar");
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "yyyy-MM-dd  HH:mm";

            openDatafileToolStripMenuItem.Enabled = false;
            closeDatafileToolStripMenuItem.Enabled = false;   
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            
            bool success = false;

            Task item = ReadInput(out success);

            if (success) {
                
                taskManager.AddItem(item);
                UpdateGUI();
            }
        }

        private Task ReadInput(out bool success)
        {
            success = false;
            Task item = new Task();

            item.DateAndTime = ReadDateAndTime(out success);

            Console.WriteLine(item.DateAndTime);
            
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
                Console.WriteLine(dateAndTime);
                success = true;
            }
            return dateAndTime;
        }

        private string ReadDescription(out bool success) {
            string description = "";
            success = false;

            if (textBox1.Text.Equals(string.Empty))
            {
                GiveMessage("Invalid description");
                cmbBox.Focus();
            }
            else {
                description = textBox1.Text;
                success = true;
            }
            return description;
        }

        private PriorityType ReadPriority (out bool success) {

            PriorityType priority = PriorityType.Less_important;

            success = false;


            if (cmbBox.Text.Equals(string.Empty))
            {
                GiveMessage("Invalid Priority");
                cmbBox.Focus();
            }
            else {
                priority = (PriorityType)Enum.Parse(typeof(PriorityType), cmbBox.Text);
                success = true;
            }

            return priority;
        }

        private void GiveMessage(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateGUI() {
            dateTimePicker.Value = DateTime.Now;
            cmbBox.SelectedIndex = (int)PriorityType.Normal;
            listBox1.Items.Clear();

            for (int i = 0; i < taskManager.Count; i++)
            {
                listBox1.Items.Add(taskManager.GetItem(i).ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        private void exitAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Avsluta?", "Important Query", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                Close();
            }
         
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

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
