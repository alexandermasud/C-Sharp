﻿namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMaxNum = new System.Windows.Forms.Label();
            this.grpInviteGuest = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEnd1 = new System.Windows.Forms.Label();
            this.lblEnd2 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumGuest = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.btnListBoxDelete = new System.Windows.Forms.Button();
            this.grpNewParty.SuspendLayout();
            this.grpInviteGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.btnCreateList);
            this.grpNewParty.Controls.Add(this.txtAmount);
            this.grpNewParty.Controls.Add(this.txtMaxNum);
            this.grpNewParty.Controls.Add(this.lblAmount);
            this.grpNewParty.Controls.Add(this.lblMaxNum);
            this.grpNewParty.Location = new System.Drawing.Point(63, 42);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(346, 135);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New Party";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(136, 106);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(75, 23);
            this.btnCreateList.TabIndex = 4;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(201, 60);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(201, 27);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new System.Drawing.Size(100, 20);
            this.txtMaxNum.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 63);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(81, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Cost per person";
            // 
            // lblMaxNum
            // 
            this.lblMaxNum.AutoSize = true;
            this.lblMaxNum.Location = new System.Drawing.Point(6, 30);
            this.lblMaxNum.Name = "lblMaxNum";
            this.lblMaxNum.Size = new System.Drawing.Size(117, 13);
            this.lblMaxNum.TabIndex = 0;
            this.lblMaxNum.Text = "Total Number of guests";
            // 
            // grpInviteGuest
            // 
            this.grpInviteGuest.Controls.Add(this.btnAdd);
            this.grpInviteGuest.Controls.Add(this.txtLastName);
            this.grpInviteGuest.Controls.Add(this.txtFirstName);
            this.grpInviteGuest.Controls.Add(this.lblLastName);
            this.grpInviteGuest.Controls.Add(this.lblFirstName);
            this.grpInviteGuest.Location = new System.Drawing.Point(63, 215);
            this.grpInviteGuest.Name = "grpInviteGuest";
            this.grpInviteGuest.Size = new System.Drawing.Size(346, 127);
            this.grpInviteGuest.TabIndex = 1;
            this.grpInviteGuest.TabStop = false;
            this.grpInviteGuest.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(201, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(201, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 77);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblEnd1
            // 
            this.lblEnd1.AutoSize = true;
            this.lblEnd1.Location = new System.Drawing.Point(72, 377);
            this.lblEnd1.Name = "lblEnd1";
            this.lblEnd1.Size = new System.Drawing.Size(55, 13);
            this.lblEnd1.TabIndex = 3;
            this.lblEnd1.Text = "Total Cost";
            // 
            // lblEnd2
            // 
            this.lblEnd2.AutoSize = true;
            this.lblEnd2.Location = new System.Drawing.Point(72, 413);
            this.lblEnd2.Name = "lblEnd2";
            this.lblEnd2.Size = new System.Drawing.Size(90, 13);
            this.lblEnd2.TabIndex = 3;
            this.lblEnd2.Text = "Number of guests";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(329, 377);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(62, 13);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "lblTotalCost";
            // 
            // lblNumGuest
            // 
            this.lblNumGuest.AutoSize = true;
            this.lblNumGuest.Location = new System.Drawing.Point(329, 413);
            this.lblNumGuest.Name = "lblNumGuest";
            this.lblNumGuest.Size = new System.Drawing.Size(67, 13);
            this.lblNumGuest.TabIndex = 3;
            this.lblNumGuest.Text = "lblNumGuest";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(460, 69);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(286, 277);
            this.listBox.TabIndex = 4;
            // 
            // lblGuestList
            // 
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Location = new System.Drawing.Point(577, 42);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(54, 13);
            this.lblGuestList.TabIndex = 5;
            this.lblGuestList.Text = "Guest List";
            // 
            // btnListBoxDelete
            // 
            this.btnListBoxDelete.Location = new System.Drawing.Point(671, 362);
            this.btnListBoxDelete.Name = "btnListBoxDelete";
            this.btnListBoxDelete.Size = new System.Drawing.Size(75, 23);
            this.btnListBoxDelete.TabIndex = 6;
            this.btnListBoxDelete.Text = "Delete";
            this.btnListBoxDelete.UseVisualStyleBackColor = true;
            this.btnListBoxDelete.Click += new System.EventHandler(this.btnListBoxDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListBoxDelete);
            this.Controls.Add(this.lblGuestList);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lblNumGuest);
            this.Controls.Add(this.lblEnd2);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblEnd1);
            this.Controls.Add(this.grpInviteGuest);
            this.Controls.Add(this.grpNewParty);
            this.Name = "MainForm";
            this.Text = "Party Organiser";
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpInviteGuest.ResumeLayout(false);
            this.grpInviteGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMaxNum;
        private System.Windows.Forms.GroupBox grpInviteGuest;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEnd1;
        private System.Windows.Forms.Label lblEnd2;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumGuest;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblGuestList;
        private System.Windows.Forms.Button btnListBoxDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

