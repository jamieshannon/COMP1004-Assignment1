/*
 * App Name: Sharp Mail Order
 * Author: Jamie Shannon
 * Date: September 30, 2016
 * Description: A simple Sales bonus calculator, user enters employee information, 
 * sales total and hours worked. The app will then calculate the the total sales bonus
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment1
{
    public partial class MailOrder : Form
    {
        public MailOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method checks if the value input for monthly sales is a valid number. If is is the number 
        /// is converted to a dollar figure else a message is shown that the information
        /// is not valid and the field is cleared.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TotalMonthlySalesTextBox_Leave(object sender, EventArgs e)
        {
            double TotalSales;
            if (TotalMonthlySalesTextBox.Text != "")
            {
                try
                {
                    TotalSales = Convert.ToDouble(TotalMonthlySalesTextBox.Text);
                    TotalMonthlySalesTextBox.Text = TotalSales.ToString("C2");
                }
                catch (Exception exception)
                {
                    try
                    {
                        TotalSales = double.Parse(TotalMonthlySalesTextBox.Text, NumberStyles.Currency);
                        TotalMonthlySalesTextBox.Text = TotalSales.ToString("C2");
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Data Entered", "Input Error");
                        Debug.WriteLine(exception.Message);
                        TotalMonthlySalesTextBox.Focus();
                        TotalMonthlySalesTextBox.Text = "";
                        TotalMonthlySalesTextBox.SelectAll();
                    }
                    
                }
            }
            
        }

        /// <summary>
        /// Method converts the labels to french when the french radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LanguagesGroupBox.Text = "Langues";
            EmployeeNameLabel.Text = "Nom de l'Employé";
            EmployeeIdLabel.Text = "ID de l'Employé";
            TotalHoursWorkedLabel.Text = "Total des Heures Travaillées";
            TotalMonthlySalesLabel.Text = "Total des Ventes Mensuelles";
            SalesBonusLabel.Text = "Bonus de Vente";
        }

        /// <summary>
        /// This method changes the labels back to english is the english radio button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LanguagesGroupBox.Text = "Languages";
            EmployeeNameLabel.Text = "Employee Name";
            EmployeeIdLabel.Text = "Employee ID";
            TotalHoursWorkedLabel.Text = "Total Hours Worked";
            TotalMonthlySalesLabel.Text = "Total Monthly Sales";
            SalesBonusLabel.Text = "Sales Bonus";
        }

        
        /// <summary>
        /// This method calculates the total sales bonus and displays the total on 
        /// the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double PercentHoursWorked;
            double TotalHoursWorked;
            double TotalMonthlySales;
            double TotalBonusAmount;
            double SalesBonus;

            try
            {
              TotalHoursWorked = Convert.ToDouble(TotalHoursWorkedNumericUpDown.Value);
              PercentHoursWorked = TotalHoursWorked / 160;

              TotalMonthlySales = double.Parse(TotalMonthlySalesTextBox.Text, NumberStyles.Currency);
              TotalBonusAmount = TotalMonthlySales * 0.02;

              SalesBonus = PercentHoursWorked * TotalBonusAmount;
              SalesBonusTextBox.Text = SalesBonus.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Monthly Sales Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                TotalMonthlySalesTextBox.Text = "";
                TotalMonthlySalesTextBox.Focus();
                
            }
          
        }

        /// <summary>
        /// Clears all the form fields except for the Total Monthly Sales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            EmployeeNameTextBox.Text = "";
            EmployeeIdTextBox.Text = "";
            TotalHoursWorkedNumericUpDown.Value = 0;
            SalesBonusTextBox.Text = "";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing", "Information is being printed");
        }
    }
}
