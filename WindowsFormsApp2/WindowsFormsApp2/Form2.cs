using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        string input = string.Empty;
        string firstmethod = string.Empty;
        string secondmethod = string.Empty;
        string method;

        // Starting with the Calculator Coding 
        public Form2()
        {
            InitializeComponent();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "8";
            this.output.Text += input;
        }

        private void xsquare_Click(object sender, EventArgs e)
        {
            output.Text = Convert.ToString(Convert.ToDecimal(output.Text) * Convert.ToDecimal(output.Text));
        }

        private void squareroot_Click(object sender, EventArgs e)
        {
            {
                double opr1;
                if (double.TryParse(output.Text, out opr1))
                {
                    output.Text = (Math.Sqrt(opr1)).ToString();
                }
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            secondmethod = input;
            double num1, num2;
            double.TryParse(firstmethod, out num1);
            double.TryParse(secondmethod, out num2);
            double result;

            if (method == "+")
            {
                result = num1 + num2;
                output.Text = Convert.ToString(result);
            }
            else if (method == "-")
            {
                result = num1 - num2;
                output.Text = Convert.ToString(result);
            }
            else if (method == "*")
            {
                result = num1 * num2;
                output.Text = Convert.ToString(result);
            }
            else if (method == "/")
            {
                if (num2 == 0)
                {
                    output.Text = "Cannot Divided by Zero";
                }
                else
                {
                    result = (num1 / num2);
                    output.Text = Convert.ToString(result);
                    num1 = result;
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            firstmethod = input;
            method = "+";
            input = string.Empty;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            firstmethod = input;
            method = "-";
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            firstmethod = input;
            method = "*";
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstmethod = input;
            method = "/";
            input = string.Empty;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            this.input = string.Empty;
            this.firstmethod = string.Empty;
            this.secondmethod = string.Empty;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + ".";
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("-"))
            {
                output.Text = output.Text.Remove(0, 1);
            }
            else
            {
                output.Text = "-" + output.Text;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "0";
            this.output.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "3";
            this.output.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "2";
            this.output.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "1";
            this.output.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "6";
            this.output.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "5";
            this.output.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "4";
            this.output.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "9";
            this.output.Text += input;
        }

        private void onebyx_Click(object sender, EventArgs e)
        {
            output.Text = Convert.ToString(Convert.ToDecimal(output.Text) / 4);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "7";
            this.output.Text += input;
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Calculator1 = new Form1();
            Calculator1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Nishat Bagga \n This Calculator has " +
                "Both Types Scientific as well as Standard ", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
