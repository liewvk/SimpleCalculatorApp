using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class Form1 : Form
    {
        private bool GetNumbers(out double firstNumber, out double secondNumber)
        {
            firstNumber = 0;
            secondNumber = 0;

            if (!double.TryParse(txtFirstNumber.Text.Trim(), out firstNumber))
            {
                MessageBox.Show("Please enter a valid first number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtFirstNumber.Focus();
                return false;
            }

            if (!double.TryParse(txtSecondNumber.Text.Trim(), out secondNumber))
            {
                MessageBox.Show("Please enter a valid second number.",
                                "Invalid Input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtSecondNumber.Focus();
                return false;
            }

            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!GetNumbers(out double firstNumber, out double secondNumber))
            {
                return;
            }

            double result = firstNumber + secondNumber;

            txtResult.Text = result.ToString("0.##");


        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {


            if (!GetNumbers(out double firstNumber, out double secondNumber))
            {
                return;
            }

            double result = firstNumber - secondNumber;

            txtResult.Text = result.ToString("0.##");


        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!GetNumbers(out double firstNumber, out double secondNumber))
            {
                return;
            }

            double result = firstNumber * secondNumber;

            txtResult.Text = result.ToString("0.##");


        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!GetNumbers(out double firstNumber, out double secondNumber))
            {
                return;
            }

            if (secondNumber == 0)
            {
                MessageBox.Show("Cannot divide by zero.",
                                "Division Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtSecondNumber.Focus();
                return;
            }

            double result = firstNumber / secondNumber;

            txtResult.Text = result.ToString("0.##");




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();

            txtFirstNumber.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                                      "Confirm Exit",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFirstNumber.Focus();
        }
    }
}
