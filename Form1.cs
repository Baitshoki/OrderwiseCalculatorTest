using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderwiseCalculator
{
    public partial class FormCaculator : Form
    {

        Calculations calc = new Calculations();

        // string Calculation = string.Empty;
        // double Number = 0;
        // bool op = true;
        // bool isDecimal = true;

        public FormCaculator()
        {
            InitializeComponent();
            calc.op = true;
            calc.isDecimal = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            Result();

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || (calc.op))
                txtResult.ResetText();
            calc.op = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (calc.isDecimal)
                {
                    txtResult.Text = txtResult.Text + button.Text;
                    calc.isDecimal = false;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }
                                  
        }


        private void Calculation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calc.Calculation = button.Text;
            calc.value = double.Parse(txtResult.Text);

            calc.op = true;
            calc.isDecimal = true;

            calc.value = double.Parse(txtResult.Text);
        }
        private void Result()
        {
            switch (calc.Calculation)
            {
                case "+":
                    txtResult.Text = Calculations.Addition(calc.value, double.Parse(txtResult.Text)).ToString();
                    break;

                case "-":
                    txtResult.Text = Calculations.Substrction(calc.value, double.Parse(txtResult.Text)).ToString();
                    break;

                case "*":
                    txtResult.Text = Calculations.Multiplication(calc.value, double.Parse(txtResult.Text)).ToString();
                    break;

                case "/":
                    txtResult.Text = Calculations.Division(calc.value, double.Parse(txtResult.Text)).ToString();
                    break;

                case "%":
                    txtResult.Text = Calculations.Division(calc.value, double.Parse(txtResult.Text)).ToString();
                    break;

                default:
                    break;

            }
            calc.op = true;
            calc.isDecimal = true;
        }

        private void FormCaculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {

                case "0":
                    btn0.PerformClick();
                    break;

                case "1":
                    btn1.PerformClick();
                    break;

                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;

                case "4":
                    btn4.PerformClick();
                    break;

                case "5":
                    btn5.PerformClick();
                    break;

                case "6":
                    btn6.PerformClick();
                    break;

                case "7":
                    btn7.PerformClick();
                    break;

                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;

                case ".":
                    btnDot.PerformClick();
                    break;


                case "*":
                    btnMultiply.PerformClick();
                    break;
                case "/":
                    btnDivide.PerformClick();
                    break;
                case "+":
                    btnPlus.PerformClick();
                    break;
                case "%":
                    btnPercentage.PerformClick();
                    break;
                case "-":
                    btnSubtract.PerformClick();
                    break;
                case "\r":
                    btnEqualTo.PerformClick();
                    break;
                default:
                    break;
            }

            if (e.KeyChar == (char)Keys.Escape)
                txtResult.Text = "0";
            }

        
    }
    }

