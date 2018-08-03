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
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string firstmethod = string.Empty;
        string secondmethod = string.Empty;
        string method;

        // Starting with the Calculator Coding 
        public Form1()
        {
            InitializeComponent();
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "0";
            this.output.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "1";
            this.output.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "2";
            this.output.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "3";
            this.output.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "4";
            this.output.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "8";
            this.output.Text += input;
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

        private void nine_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "9";
            this.output.Text += input;
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

        private void seven_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            input += "7";
            this.output.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            this.input = string.Empty;
            this.firstmethod = string.Empty;
            this.secondmethod = string.Empty;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Calculator2 = new Form2();
            Calculator2.ShowDialog();
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
