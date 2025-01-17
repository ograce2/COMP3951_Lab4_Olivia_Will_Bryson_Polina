using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
{
    public partial class Form1 : Form
    {

        Calculation calculation;

        public Form1()
        {
            InitializeComponent();

        }

        // appends the digit to the textbox
        private void buttonDigit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digit clicked!");
        }

        // set operand1 of the Calculation object to be the value in the textbox
        // if operand1, operand2, oepration are set then set operand1 to be their result, else set operand1 to be
        // the value in the textbox (unless 1/x or x^2)
        private void buttonOperation_Click(object sender, EventArgs e)
        {

        }

        // sets value in textbox to be opposite parity
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {

        }

        // sets Calculation.M to be 0
        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {

        }

        // gets the value of Calculation.M
        private void buttonMemoryRecall_Click(object sender, EventArgs e)
        {

        }

        // sets the value of memory to be the number in the textbox
        private void buttonMemoryAssign_Click(object sender, EventArgs e)
        {

        }

        // adds the value in the textbox to memory
        private void buttonMemoryAdd_Click(object sender, EventArgs e)
        {

        }

        // clear the current operand
        private void buttonClearCurrent_Click(object sender, EventArgs e)
        {

        }

        // clear all (C button --> check lab instructions for exact)
        private void buttonClearAll_Click(object sender, EventArgs e)
        {

        }

        // removes last digit from textbox
        private void buttonBackspace_Click(object sender, EventArgs e)
        {

        }

        // equals operation, calls Calculation.performCalculation and puts result in textbox
        private void buttonEquals_Click(object sender, EventArgs e)
        {

        }

        // enables/disables the buttons and loads image into picture box at bottom of the screen
        private void buttonOnOff_Click(object sender, EventArgs e)
        {

        }

        // creates a new calculation object
        private void Form1_Load(object sender, EventArgs e)
        {
 
        }
    }
}
