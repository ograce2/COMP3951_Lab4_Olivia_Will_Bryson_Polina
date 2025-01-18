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
        /// Stores a binary operation for calculation. The binary operation can be /, *, -, +, or %.
        /// </summary>
        private String operation;

        /// <summary>
        /// Stores the value saved to memory.
        /// </summary>
        private double memory;

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
        /// If newOperation is a unary operation (x^2, 1/x, or sqrt) then newOperation acts on operand1 or operand2, depending on which is set, stores its result
        /// in that operand, and then returns the result.
        /// 
        /// If newOperationi is a binary operation (+, - , *, /, or %) then performCalculation is called for the existing operand1, operand2, and operation. If a non-null 
        /// result is calculated then that result is returned and stored in operand1, newOperation is stored in oepration, and operand2 is set to null. If a null result is 
        /// calculated, then operand1 is set to 0, operation is set to newOperation, and operand2 is set to null.
        /// 
        /// </summary>
        /// <param name="newOperation"></param>
        /// <returns></returns>
        public double? setOperation(String newOperation)
        {
            double? result = null;


            // Check if we are working with a unary operation or a binary operation
            if (newOperation == "sqrt" || newOperation == "1/x" || newOperation == "x^2")
            {
                // Unary operations are not stored in operation, they will act on operand2 or operand1 (depending on what is set) and then store the result in the
                // operand that they acted on.

            } else 
            {
                // First call performCalculation
                result = performCalculation();
                if (result != null)
                {
                    operand1 = result;
                    operation = newOperation;
                    operand2 = null;
                } else
                {
                    operand1 = 0;
                    operation = newOperation;
                    operand2 = null;
                }

            }



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
            if (operand1 == null)
            {
                operand1 = newOperand;
            } else if (operand2 == null)
            {
                operand2 = newOperand;
            } else if (operand1.HasValue && operand2.HasValue)
            {
                operand1 = newOperand;
                operand2 = null;
                operation = null;
            }
        }

        /// <summary>
        /// Performs the calculation bases on what is stored in operand1, operation, or operand2 and returns the result. If operation is empty, then operand1 is returned.
        /// </summary>
        /// <returns></returns>
        public double? performCalculation()
        {
            double? result = null;

            if (operand1.HasValue && operand2.HasValue && operation != "")
            {
                if (operation == "/")
                {
                    if (operand2 == 0)
                    {
                        result = null;
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                } else if (operation == "*"){
                    result = operand1 * operand2;
                } else if (operation == "-")
                {
                    result = operand1 - operand2;
                } else if (operation == "+")
                {
                    result = operand1 + operand2;
                } else if (operation == "%")
                {
                    result = operand1 * 0.01 * operand2;
                }
            } else
            {
                result = operand1;
            }




            return result;
        }

        
    }
}
