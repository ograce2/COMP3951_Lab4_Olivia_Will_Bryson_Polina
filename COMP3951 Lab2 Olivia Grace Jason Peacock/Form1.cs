using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void button_Click(object sender, EventArgs e)
        {
            Button buttonClicked;
            String buttonText;

            buttonClicked = (Button)sender;
            buttonText = buttonClicked.Text;

            inputInterpreter(buttonText);

            this.ActiveControl = null;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] validInputs = { '*', '/', '-', '+', '%', '^', 'i', '=' };

            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i) || validInputs.Contains(e.KeyChar))
            {
                inputInterpreter(e.KeyChar.ToString());
            }
        }

        //Seperate for handling enter
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Equals();
            }
        }

        private void inputInterpreter(string input)
        {
            string[] operationInputs = { "*", "/", "-", "+", "%", "^", "i", "1/x", "x^2", "sqrt" };

            int i;
            if (int.TryParse(input, out i) || input.Equals("."))
            {
                handleNumericInput(input);
            }
            else if (operationInputs.Contains(input))
            {
                switch (input)
                {
                    case "^": input = "x^2"; break;
                    case "i": input = "1/x"; break;
                    case "s": input = "sqrt"; break;
                }

                handleOperationInputs(input);
            }
            else
            {
                //Enter behaviour? We want it to do equals button
                switch (input)
                {
                    case "+/-": PlusMinus(); break;
                    case "CE": ClearCurrent(); break;
                    case "C": ClearAll(); break;
                    case "<-": Backspace(); break;
                    case "=": Equals(); break;
                    case "MC": MemoryClear(); break;
                    case "MR": MemoryRecall(); break;
                    case "MS": MemoryAssign(); break;
                    case "M+": MemoryAdd(); break;
                    case "On": togglePower(); break;
                    case "Off": togglePower(); break;
                    default: MessageBox.Show("INVALID INPUT SPECIFIED"); break;
                }
            }
        }

        private void handleNumericInput(string input)
        {
            string currentBoxText = textBoxCalculation.Text;

            // set display to nothing in anticipation of a replacement if current is just 0 and incoming isn't a decimal
            if (currentBoxText.Equals("0") && input != ".")
            {
                currentBoxText = "";
            }

            // allows replacing of number on display rather than appending after an operation with two operands
            if (!calculator.Operation.Equals("") && justEnteredOperation == true)
            {
                textBoxCalculation.Text = input;
                justEnteredOperation = false;
            }
            // ignores duplicate decimal point input
            else if (currentBoxText.Contains(".") && input.Equals("."))
            {
                // do nothing
            }
            // otherwise concatenate new digit
            else
            {
                textBoxCalculation.Text = String.Concat(currentBoxText, input);
            }
        }

        // set operand1 of the Calculation object to be the value in the textbox
        // if operand1, operand2, oepration are set then set operand1 to be their result, else set operand1 to be
        // the value in the textbox (unless 1/x or x^2)
        private void handleOperationInputs(string input)
        {
            String currentBoxText = textBoxCalculation.Text;

            double? result;
            double textBoxNumber = Double.Parse(textBoxCalculation.Text);

            calculator.setOperand(textBoxNumber);

            result = calculator.setOperation(input);

            if (result != null)
            {
                textBoxCalculation.Text = result.ToString();
            }
            if (input != "1/x" && input != "x^2" && input != "sqrt")
            {
                justEnteredOperation = true;
            }
        }

        // sets value in textbox to be opposite parity
        private void PlusMinus()
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
        private void MemoryClear()
        {
            calculator.Memory = 0;
        }

        // sets the textbox to be the value in memory
        private void MemoryRecall()
        {
            textBoxCalculation.Text = calculator.Memory.ToString();
        }

        // assigns the value in the textbox to memory
        private void MemoryAssign()
        {
            double textBoxNumber = Double.Parse(textBoxCalculation.Text);

             calculator.Memory = textBoxNumber;
        }

        // adds the value in the textbox to memory
        private void MemoryAdd()
        {
            double textBoxNumber = Double.Parse(textBoxCalculation.Text);

            calculator.Memory += textBoxNumber;
        }

        // clear the current operand
        private void ClearCurrent()
        {
            calculator.clearCurrent();
            textBoxCalculation.Text = "0";
        }

        // clear all (C button --> check lab instructions for exact)
        private void ClearAll()
        {
            calculator.clearAll();
            textBoxCalculation.Text = "0";
        }

        // removes last digit from textbox
        private void Backspace()
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
        private void Equals()
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
        private void togglePower()
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
