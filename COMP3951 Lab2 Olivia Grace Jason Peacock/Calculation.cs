using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
{
    internal class Calculation
    {
        //Stores the power state of the calulator
        private bool on = false;

        //Stores the first operator input (nullable so we can check if a value is present) (can it ever be null?)
        private double? operand1;

        //Stores the second operator input (nullable so we can check if a value is present)
        private double? operand2;

        //Stores the number held in memory
        private double m;

        //Stores the current operand
        private String operator1;

        //Stores the current number in the textBoxDisplay
        private double textBoxDisplay;

        //Button Click Handler
        //Handle all clicks of buttons by redirecting to correct function
        public void buttonClickHandler()
        {

        }

        //Update Text Box
        //Update the text box to display a double
        public void updateTextBox(double x)
        {
        }

        //Numeric Input
        //Take input from panelDigits buttons and update the string that stores the current number
        //Example: Current textBoxDisplay value is 8.7 and 5 was just selected. Update to 8.75
        public void numericInput()
        {

        }

        //Operations Input
        //Handle input from panelOperations
        //Example: "*" button was just pressed, is set as operator1. Check if both operands are non null using
        //operandsNonNull, perform operation and update operands and operator1 appropriately if so.
        //just store as operand1 otherwise
        //
        //SOME OPERATORS WORK DIFFERENTLY WITH ONLY ONE INPUT EVEN IN SECOND OPERATOR LIKE X^2 DISCUSS
        //DIFFERENT FUNCTION FOR EACH OPERATOR?
        public void operationInput(String str)
        {

        }

        //CE
        //Implement CE functionality. Clearing current operand but not previous operation
        //Example: first operation [5 * 3 = 15]
        //15 is now in operand1
        //user presses * then 2
        //Current situation is operand1 = 15, operator1 = *, operand2 = 2
        //instead of equals or another operand, user presses CE
        //remove operator1 and operand2 and display 0 on the screen
        //operand1 is still 15 (THIS IS SLIGHTLY DIFFERENT TO HOW IT IS IN HER EXAMPLE DISCUSS)
        //calls c() if operand1 is null
        public void ce()
        {

        }

        //C
        //Implement C functionality. Clear all operands and operators
        public void c()
        {

        }

        //Backspace
        //Implement backspace functionality.
        //Remove one digit from right side of current number in text box
        //Edge case when length is one ie. 7 and ∞. Result should be 0 in this case.
        //Edge case when digit one right of decimal is encountered, ensure decimal is also removed
        //Edge case when length is 2 but first "digit" is negative symbol, should set to 0.
        public void backspace()
        {

        }

        //Equals
        //If operand1, operand2, and operator1 are non null, perform calculation,
        //set operand1 to result and set operand2 and operator1 to null
        //In case where operand2 is null but operand1 and operator1 are not, perform operation using operand1 as both operands
        //(THAT IS BEHAVIOUR PROF HAS IMPLEMENTED MAYBE DISCUSS)
        public void equals()
        {

        }

        //Toggle Power
        //Toggles the power state of the calculator
        //Should disable / enable pressing all other buttons and clear all operands and operators and textbox
        //as well as calling to display or hide image
        public void togglePower()
        {

        }

        //MC
        //sets the value of m to zero
        public void mc()
        {

        }

        //MR
        //Recalls the m variable to the textbox
        public void mr()
        {

        }

        //MS
        //Set the m variable to the current value
        public void ms()
        {

        }

        //MPlus
        //Adds the current value to the m variable
        public void mPlus()
        {

        }
        
        //Operands Non Null
        //Returns whether both operands are full for purposes of determining wether to execute operators
        //Example: Return false if either operand1 or operand2 are null
        //DISCUSS IF OPERAND1 CAN EVER BE NULL?
        private bool operandsNonNull()
        {
            if(operand1.HasValue && operand2.HasValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
