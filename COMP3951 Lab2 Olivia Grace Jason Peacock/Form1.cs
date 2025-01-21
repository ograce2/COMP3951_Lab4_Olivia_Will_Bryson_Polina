using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 2: Scientific Calculator
/// Include here the authors: Jason Peacock and Olivia Grace
/// Include here date/revisions: January 21, 2025
/// </summary>
namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
{
    public partial class Form1 : Form
    {

        Calculator calculator;

        bool justEnteredOperation = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        // appends the digit to the textbox
        private void buttonDigit_Click(object sender, EventArgs e)
        {
            Button buttonClicked;
            String currentBoxText;
            String buttonText;

            buttonClicked = (Button)sender;
            currentBoxText = textBoxCalculation.Text;
            buttonText = buttonClicked.Text;

            // set display to nothing in anticipation of a replacement if current is just 0 and incoming isn't a decimal
            if (currentBoxText.Equals("0") && buttonText != ".")
            {
                currentBoxText = "";
            }

            // allows replacing of number on display rather than appending after an operation with two operands
            if (!calculator.Operation.Equals("") && justEnteredOperation == true)
            {
                textBoxCalculation.Text = buttonClicked.Text;
                justEnteredOperation = false;
            }
            // ignores duplicate decimal point input
            else if (currentBoxText.Contains(".") && buttonText.Equals("."))
            {
                // do nothing
            }
            // otherwise concatenate new digit
            else
            {
                textBoxCalculation.Text = String.Concat(currentBoxText, buttonClicked.Text);
            }
        }

        // set operand1 of the Calculation object to be the value in the textbox
        // if operand1, operand2, oepration are set then set operand1 to be their result, else set operand1 to be
        // the value in the textbox (unless 1/x or x^2)
        private void buttonOperation_Click(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;

            String currentBoxText = textBoxCalculation.Text;
            String selectedOperation = buttonClicked.Text;

            double? result;
            double textBoxNumber = Double.Parse(textBoxCalculation.Text);

            calculator.setOperand(textBoxNumber);

            result = calculator.setOperation(selectedOperation);

            if (result != null)
            {
                textBoxCalculation.Text = result.ToString();
            }
            if(selectedOperation != "1/x" && selectedOperation != "x^2" && selectedOperation != "sqrt")
            {
                justEnteredOperation = true;
            }
        }

        // sets value in textbox to be opposite parity
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            String currentBoxText = textBoxCalculation.Text;

            if (currentBoxText[0].Equals('-'))
            {
                textBoxCalculation.Text = currentBoxText.Remove(0, 1);
            }
            else
            {
                textBoxCalculation.Text = String.Concat("-", currentBoxText);
            }
        }

        // sets Calculation.M to be 0
        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            calculator.Memory = 0;
        }

        // sets the textbox to be the value in memory
        private void buttonMemoryRecall_Click(object sender, EventArgs e)
        {
            textBoxCalculation.Text = calculator.Memory.ToString();
        }

        // assigns the value in the textbox to memory
        private void buttonMemoryAssign_Click(object sender, EventArgs e)
        {
            double textBoxNumber = Double.Parse(textBoxCalculation.Text);

             calculator.Memory = textBoxNumber;
        }

        // adds the value in the textbox to memory
        private void buttonMemoryAdd_Click(object sender, EventArgs e)
        {
            double textBoxNumber = Double.Parse(textBoxCalculation.Text);

            calculator.Memory += textBoxNumber;
        }

        // clear the current operand
        private void buttonClearCurrent_Click(object sender, EventArgs e)
        {
            calculator.clearCurrent();
            textBoxCalculation.Text = "0";
        }

        // clear all (C button --> check lab instructions for exact)
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            calculator.clearAll();
            textBoxCalculation.Text = "0";
        }

        // removes last digit from textbox
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            String currentBoxText = textBoxCalculation.Text;
            String updatedBoxText;

            if(currentBoxText.Length == 1)
            {
                updatedBoxText = "0";
            }
            else
            {
                updatedBoxText = currentBoxText.Remove(currentBoxText.Length - 1, 1);
            }

            textBoxCalculation.Text = updatedBoxText;
        }

        // equals operation, calls Calculation.performCalculation and puts result in textbox
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double textBoxNumber = Double.Parse(textBoxCalculation.Text);
            double? result;

            calculator.setOperand(textBoxNumber);

            result = calculator.performCalculation();

            if (result != null)
            {
                textBoxCalculation.Text = result.ToString();
            }
        }

        // enables/disables the buttons and loads image into picture box at bottom of the screen
        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            calculator.clearAll();

            buttonOnOff.Text = buttonOnOff.Text.Equals("On") ? "Off" : "On";

            textBoxCalculation.Text = "0";

            textBoxCalculation.Enabled = !textBoxCalculation.Enabled;

            button0.Enabled = !button0.Enabled;
            button1.Enabled = !button1.Enabled;
            button2.Enabled = !button2.Enabled;
            button3.Enabled = !button3.Enabled;
            button4.Enabled = !button4.Enabled;
            button5.Enabled = !button5.Enabled;
            button6.Enabled = !button6.Enabled;
            button7.Enabled = !button7.Enabled;
            button8.Enabled = !button8.Enabled;
            button9.Enabled = !button9.Enabled;
            buttonDecimal.Enabled = !buttonDecimal.Enabled;
            buttonPlusMinus.Enabled = !buttonPlusMinus.Enabled;

            buttonDivide.Enabled = !buttonDivide.Enabled;
            buttonMultiply.Enabled = !buttonMultiply.Enabled;
            buttonSubtract.Enabled = !buttonSubtract.Enabled;
            buttonAdd.Enabled = !buttonAdd.Enabled;
            buttonSquareRoot.Enabled = !buttonSquareRoot.Enabled;
            buttonPercent.Enabled = !buttonPercent.Enabled;
            buttonInverse.Enabled = !buttonInverse.Enabled;
            buttonSquare.Enabled = !buttonSquare.Enabled;

            buttonClearCurrent.Enabled = !buttonClearCurrent.Enabled;
            buttonClearAll.Enabled = !buttonClearAll.Enabled;
            buttonBackspace.Enabled = !buttonBackspace.Enabled;
            buttonEquals.Enabled = !buttonEquals.Enabled;

            buttonMemoryClear.Enabled = !buttonMemoryClear.Enabled;
            buttonMemoryRecall.Enabled = !buttonMemoryRecall.Enabled;
            buttonMemoryAssign.Enabled = !buttonMemoryAssign.Enabled;
            buttonMemoryAdd.Enabled = !buttonMemoryAdd.Enabled;

            pictureBoxImage.Visible = !pictureBoxImage.Visible;
        }

        // creates a new calculation object
        private void Form1_Load(object sender, EventArgs e)
        {
            calculator = new Calculator();
        }
    }
}
