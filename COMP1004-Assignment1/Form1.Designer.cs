namespace COMP1004_Assignment1
{
    partial class Form1
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
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursWorkedNumericUpDown)).BeginInit();
            this.LanguagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(225, 84);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNameTextBox.TabIndex = 0;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(225, 121);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIdTextBox.TabIndex = 1;
            // 
            // TotalMonthlySalesTextBox
            // 
            this.TotalMonthlySalesTextBox.Location = new System.Drawing.Point(225, 195);
            this.TotalMonthlySalesTextBox.Name = "TotalMonthlySalesTextBox";
            this.TotalMonthlySalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalMonthlySalesTextBox.TabIndex = 3;
            this.TotalMonthlySalesTextBox.TextChanged += new System.EventHandler(this.TotalMonthlySalesTextBox_TextChanged);
            this.TotalMonthlySalesTextBox.Leave += new System.EventHandler(this.TotalMonthlySalesTextBox_Leave);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(108, 87);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.EmployeeNameLabel.TabIndex = 4;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(108, 124);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIdLabel.TabIndex = 5;
            this.EmployeeIdLabel.Text = "Employee ID";
            // 
            // TotalHoursWorkedLabel
            // 
            this.TotalHoursWorkedLabel.AutoSize = true;
            this.TotalHoursWorkedLabel.Location = new System.Drawing.Point(108, 161);
            this.TotalHoursWorkedLabel.Name = "TotalHoursWorkedLabel";
            this.TotalHoursWorkedLabel.Size = new System.Drawing.Size(103, 13);
            this.TotalHoursWorkedLabel.TabIndex = 6;
            this.TotalHoursWorkedLabel.Text = "Total Hours Worked";
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.AutoSize = true;
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(108, 198);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(100, 13);
            this.TotalMonthlySalesLabel.TabIndex = 7;
            this.TotalMonthlySalesLabel.Text = "Total Monthly Sales";
            // 
            // TotalHoursWorkedNumericUpDown
            // 
            this.TotalHoursWorkedNumericUpDown.Location = new System.Drawing.Point(225, 159);
            this.TotalHoursWorkedNumericUpDown.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.TotalHoursWorkedNumericUpDown.Name = "TotalHoursWorkedNumericUpDown";
            this.TotalHoursWorkedNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.TotalHoursWorkedNumericUpDown.TabIndex = 8;
            // 
            // SalesBonusTextBox
            // 
            this.SalesBonusTextBox.Location = new System.Drawing.Point(225, 232);
            this.SalesBonusTextBox.Name = "SalesBonusTextBox";
            this.SalesBonusTextBox.ReadOnly = true;
            this.SalesBonusTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesBonusTextBox.TabIndex = 9;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(109, 235);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(66, 13);
            this.SalesBonusLabel.TabIndex = 10;
            this.SalesBonusLabel.Text = "Sales Bonus";
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguagesGroupBox.Location = new System.Drawing.Point(112, 24);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Size = new System.Drawing.Size(213, 39);
            this.LanguagesGroupBox.TabIndex = 11;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Languages";
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(37, 16);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(123, 16);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.TabStop = true;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 313);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TotalHoursWorkedNumericUpDown)).EndInit();
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
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
    }
}

