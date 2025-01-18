using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
{
    // Olivia 
    internal class Calculation
    {

        /// <summary>
        /// Stores the first operand of a calculation
        /// </summary>
        private double? operand1;

        /// <summary>
        /// Stores the second operand of a calculation
        /// </summary>
        private double? operand2;

        /// <summary>
        /// Stores the value saved to memory.
        /// </summary>
        private double memory;

        /// <summary>
        /// Stores the operation of the calculation
        /// </summary>
        private String operation;

        /// <summary>
        /// Memory property.
        /// </summary>
        double Memory
        {
            get { return memory; }

            set { memory = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Calculation()
        {
            operand1 = null;
            operand2 = null;
            operation = "";
            memory = 0;
        }

        /// <summary>
        /// Sets the value of operation attribute to the value of the parameter passed. If a calculation must be performed in order to set the operation, the result of the 
        /// calculation will be returned (i.e. if operand1 = 1, operand2 = 2, operation = '+' when this function is called then 1+2 will be performed, 3 will be returned.)
        /// If no calculation is needed to be performed, then null is returned. (i.e. if operand1 = 1, operand2 = null, and operation = "" when this functioin
        /// is called then null is returned)
        /// 
        /// If operand1, operand2, and operation are all not null then performCalculation is called and the result is stored in operand1 and returned before setting operation to
        /// newOperation and operand2 to null.
        /// If operand2 and operation are null then operation is set to newOperation and null is returned.
        /// 
        /// May be special cases for 1/x and x^2 operations...
        /// </summary>
        /// <param name="newOperation"></param>
        /// <returns></returns>
        public double? setOperation(String newOperation)
        {
            double? result = null;
            return result;
        }

        /// <summary>
        /// Sets either operand1 or operand2 to be newOperand depending on the current values of operand1 and operand2.
        /// 
        /// If operand1 is null, then operand1 is set to newOperand.
        /// If operand1 is not null and operand 2 is null then operand2 is set to newOperand.
        /// If operand1 and operand2 are both not null, then operand1 is set to newOperand and operation and operand2 are set to null.
        /// </summary>
        /// <param name="newOperand"></param>
        public void setOperand(double newOperand)
        {

        }

        /// <summary>
        /// Performs the calculation bases on what is stored in operand1, operation, or operand2 and returns the result. If a calculation can not be performed for some reason,
        /// (i.e. operation has not been set or divide by zero or something) then null is returned.
        /// </summary>
        /// <returns></returns>
        public double? performCalculation()
        {
            double? result = null;
            return result;
        }

        
    }
}
