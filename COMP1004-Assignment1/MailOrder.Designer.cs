/*
 * App Name: Sharp Mail Order
 * Author: Jamie Shannon
 * Date: September 30, 2016
 * Description: A simple Sales bonus calculator, user enters employee information, 
 * sales total and hours worked. The app will then calculate the the total sales bonus
 */

namespace COMP1004_Assignment1
{
    partial class MailOrder
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
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIdLabel = new System.Windows.Forms.Label();
            this.TotalHoursWorkedLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.TotalHoursWorkedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SalesBonusTextBox = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.LanguagesGroupBox = new System.Windows.Forms.GroupBox();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursWorkedNumericUpDown)).BeginInit();
            this.LanguagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(190, 123);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameTextBox.TabIndex = 0;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(190, 160);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIdTextBox.TabIndex = 1;
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(190, 234);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalMonthlySalesTextBox.TabIndex = 3;
            this.TotalMonthlySalesTextBox.Leave += new System.EventHandler(this.TotalMonthlySalesTextBox_Leave);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(32, 126);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeeNameLabel.TabIndex = 4;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(32, 163);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIdLabel.TabIndex = 5;
            this.EmployeeIdLabel.Text = "Employee ID";
            // 
            // TotalHoursWorkedLabel
            // 
            this.TotalHoursWorkedLabel.AutoSize = true;
            this.TotalHoursWorkedLabel.Location = new System.Drawing.Point(32, 200);
            this.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel";
            this.TotalHoursWorkedLabel.Size = new System.Drawing.Size(103, 13);
            this.TotalHoursWorkedLabel.TabIndex = 6;
            this.TotalHoursWorkedLabel.Text = "Total Hours Worked";
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.AutoSize = true;
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(32, 237);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(100, 13);
            this.TotalMonthlySalesLabel.TabIndex = 7;
            this.TotalMonthlySalesLabel.Text = "Total Monthly Sales";
            // 
            // TotalHoursWorkedNumericUpDown
            // 
            this.TotalHoursWorkedNumericUpDown.Location = new System.Drawing.Point(190, 198);
            this.TotalHoursWorkedNumericUpDown.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.TotalHoursWorkedNumericUpDown.Name = "TotalHoursWorkedNumericUpDown";
            this.TotalHoursWorkedNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.TotalHoursWorkedNumericUpDown.TabIndex = 2;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(190, 271);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextBox.TabIndex = 9;
            this.SalesBonusTextBox.TabStop = false;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(33, 274);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(66, 13);
            this.SalesBonusLabel.TabIndex = 10;
            this.SalesBonusLabel.Text = "Sales Bonus";
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguagesGroupBox.Location = new System.Drawing.Point(35, 60);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Size = new System.Drawing.Size(213, 39);
            this.LanguagesGroupBox.TabIndex = 11;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Languages";
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(123, 16);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(37, 16);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::COMP1004_Assignment1.Properties.Resources.sharp;
            this.LogoPictureBox.Location = new System.Drawing.Point(36, 11);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(51, 33);
            this.LogoPictureBox.TabIndex = 12;
            this.LogoPictureBox.TabStop = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(36, 322);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(138, 322);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(240, 322);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 6;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(327, 369);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.LanguagesGroupBox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.SalesBonusTextBox);
            this.Controls.Add(this.TotalHoursWorkedNumericUpDown);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.TotalHoursWorkedLabel);
            this.Controls.Add(this.EmployeeIdLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.TotalMonthlySalesTextBox);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Name = "MailOrder";
            this.Text = "Sharp Mail Order";
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursWorkedNumericUpDown)).EndInit();
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextBox;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIdLabel;
        private System.Windows.Forms.Label TotalHoursWorkedLabel;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.NumericUpDown TotalHoursWorkedNumericUpDown;
        private System.Windows.Forms.TextBox SalesBonusTextBox;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.GroupBox LanguagesGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrintButton;
    }
}

