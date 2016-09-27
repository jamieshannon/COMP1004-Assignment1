using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TotalHoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TotalMonthlySalesTextBox_TextChanged(object sender, EventArgs e)
        {
                     
        }

        private void TotalMonthlySalesTextBox_Leave(object sender, EventArgs e)
        {
            double TotalSales;
            try
            {
                TotalSales = Convert.ToDouble(TotalMonthlySalesTextBox.Text);
                TotalMonthlySalesTextBox.Text = TotalSales.ToString("C2");
            }
            catch (Exception exception)
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
