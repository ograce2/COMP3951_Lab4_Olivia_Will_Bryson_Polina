using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 2: Scientific Calculator
/// Include here the authors: Jason Peacock and Olivia Grace
/// Include here date/revisions:
/// Source:
/// </summary>
namespace COMP3951_Lab2_Olivia_Grace_Jason_Peacock
{
    /// <summary>
    /// The Calculator class represents a calculator that can perform binary and unary operations and store memory. It contains attributes to represent two operands, an 
    /// operation, and memory, as well as methods to access and update these attributes.
    /// </summary>
    internal class Calculator
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
        public Calculator()
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
        public double? setOperation(string newOperation)
        {
            double? result = null;

            // Check if we are working with a unary operation or a binary operation
            if (newOperation == "sqrt" || newOperation == "1/x" || newOperation == "x^2")
            {

                if (operand2.HasValue)
                {
                    operand2 = performUnaryCalculation(newOperation, operand2 ?? 0);
                }
                else
                {
                    operand1 = performUnaryCalculation(newOperation, operand1 ?? 0);
                }

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
        /// Performs a unary calculation and returns the result. The operation parameter specifies the operator and the operand parameter specifies the operand for the 
        /// unary calculation. The operation parameter can be 1/x, x^2, or sqrt.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="operand"></param>
        /// <returns></returns>
        private double performUnaryCalculation(string operation, double operand)
        {
            double result = 0;
            if (operation == "1/x")
            {
                if (operand == 0)
                {
                    result = Double.PositiveInfinity;
                }
                else
                {
                    result = 1 / operand;
                }
            } else if (operation == "x^2")
            {
                result = operand * operand;
            } else if (operation == "sqrt")
            {
                result = Math.Sqrt(operand);
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
        /// Performs a binary calculation bases on what is stored in operand1, operation, or operand2 and returns the result. If operation is empty, then operand1 is returned.
        /// </summary>
        /// <returns></returns>
        public double? performCalculation()
        {
            double? result = null;


            // Not sure if we need this, but I think this would help match the logic in the example calculator -- but the logic seems a bit strange...
            if (operand2 == null && operand1.HasValue && operation != "")
            {
                operand2 = operand1;
            }

            if (operand1.HasValue && operand2.HasValue && operation != "")
            {
                if (operation == "/")
                {
                    if (operand2 == 0)
                    {
                        result = Double.PositiveInfinity;
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
