using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int total = 0;
        char prevOperation = ' ';
        int addClicked = 0;
        int subtractClicked = 0;
        int multiplyClicked = 0;
        int divideClicked = 0;
        int calculateClicked = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculate()
        {
            if (prevOperation == ' ')
            {
                total = Convert.ToInt32(lblDisplay.Text);
                lblDisplay.Text = "0";
            }
            else
            {
                if (prevOperation == '+')
                {
                    total = total + Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }

                if (prevOperation == '-')
                {
                    total = total - Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }

                if (prevOperation == '*')
                {
                    total = total * Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }

                if (prevOperation == '/')
                {
                    total = total / Convert.ToInt32(lblDisplay.Text);
                    lblDisplay.Text = "0";
                }
            }

            if (addClicked == 1)
            {
                prevOperation = '+';
                addClicked = 0;
            }

            else if (subtractClicked == 1)
            {
                prevOperation = '-';
                subtractClicked = 0;
            }

            else if (multiplyClicked == 1)
            {
                prevOperation = '*';
                multiplyClicked = 0;
            }

            else if (divideClicked == 1)
            {
                prevOperation = '/';
                divideClicked = 0;
            }

            else
            {
                prevOperation = ' ';
                calculateClicked = 0;
                lblDisplay.Text = Convert.ToString(total);
            }
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            total = 0;
            prevOperation = ' ';
            addClicked = 0;
            subtractClicked = 0;
            multiplyClicked = 0;
            divideClicked = 0;
        }

        private void dig0_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "0";
            }
            else
            {
                lblDisplay.Text += "0";
            }
        }

        private void dig1_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "1";
            }
            else
            {
                lblDisplay.Text += "1";
            }
        }

        private void dig2_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "2";
            }
            else
            {
                lblDisplay.Text += "2";
            }
        }

        private void dig3_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "3";
            }
            else
            {
                lblDisplay.Text += "3";
            }
        }

        private void dig4_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "4";
            }
            else
            {
                lblDisplay.Text += "4";
            }
        }

        private void dig5_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "5";
            }
            else
            {
                lblDisplay.Text += "5";
            }
        }

        private void dig6_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "6";
            }
            else
            {
                lblDisplay.Text += "6";
            }
        }

        private void dig7_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "7";
            }
            else
            {
                lblDisplay.Text += "7";
            }
        }

        private void dig8_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "8";
            }
            else
            {
                lblDisplay.Text += "8";
            }
        }

        private void dig9_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "9";
            }
            else
            {
                lblDisplay.Text += "9";
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            addClicked = 1;
            calculate();
        }

        private void cmdSubtract_Click(object sender, EventArgs e)
        {
            subtractClicked = 1;
            calculate();
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            multiplyClicked = 1;
            calculate();
        }

        private void cmdDivide_Click(object sender, EventArgs e)
        {
            divideClicked = 1;
            calculate();
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            calculateClicked = 1;
            calculate();
        }
    }
}
