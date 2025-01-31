﻿namespace Assignment3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnUsUnit = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResultsYourBmi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(384, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(30, 85);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(61, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height (cm)";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(117, 82);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(60, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(117, 109);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(60, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(30, 112);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 13);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnUsUnit);
            this.groupBox1.Controls.Add(this.rbtnMetric);
            this.groupBox1.Location = new System.Drawing.Point(301, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rbtnUsUnit
            // 
            this.rbtnUsUnit.AutoSize = true;
            this.rbtnUsUnit.Location = new System.Drawing.Point(7, 43);
            this.rbtnUsUnit.Name = "rbtnUsUnit";
            this.rbtnUsUnit.Size = new System.Drawing.Size(108, 17);
            this.rbtnUsUnit.TabIndex = 1;
            this.rbtnUsUnit.TabStop = true;
            this.rbtnUsUnit.Text = "US Unit (foot, ibs)";
            this.rbtnUsUnit.UseVisualStyleBackColor = true;
            this.rbtnUsUnit.CheckedChanged += new System.EventHandler(this.rbtnUsUnit_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(7, 19);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(114, 17);
            this.rbtnMetric.TabIndex = 0;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric Unit (kg cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Location = new System.Drawing.Point(190, 212);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(181, 45);
            this.btnCalculateBMI.TabIndex = 7;
            this.btnCalculateBMI.Text = "Calculate";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblCategory);
            this.grpResults.Controls.Add(this.label2);
            this.grpResults.Controls.Add(this.lblResultsYourBmi);
            this.grpResults.Controls.Add(this.label4);
            this.grpResults.Location = new System.Drawing.Point(33, 263);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(468, 100);
            this.grpResults.TabIndex = 8;
            this.grpResults.TabStop = false;
            // 
            // lblResultsYourBmi
            // 
            this.lblResultsYourBmi.AutoSize = true;
            this.lblResultsYourBmi.Location = new System.Drawing.Point(384, 25);
            this.lblResultsYourBmi.Name = "lblResultsYourBmi";
            this.lblResultsYourBmi.Size = new System.Drawing.Size(34, 13);
            this.lblResultsYourBmi.TabIndex = 2;
            this.lblResultsYourBmi.Text = "lblBmi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your BMI";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight Category";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(387, 57);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "lblCategory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 388);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnUsUnit;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblResultsYourBmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label2;
    }
}

