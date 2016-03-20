using System;

namespace CalculatorNameSpace
{
    /// <summary>
    /// Implementation of
    /// Calculator class methods
    /// </summary>
    public class Calculator
    {
        private IStack stack;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="stack"></param>
        public Calculator(IStack stack)
        {
            this.stack = stack;
        }

        /// <summary>
        /// Adds new element to stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            stack.Push(value);
        }

        /// <summary>
        /// Adds the first two numbers from stack
        /// </summary>
        public void Addition()
        {
            int first = stack.Pop();
            int second = stack.Pop();
            stack.Push(second + first);
        }

        /// <summary>
        /// Subtracts one number from another from stack
        /// </summary>
        public void Subtraction()
        {
            int first = stack.Pop();
            int second = stack.Pop();
            stack.Push(second - first);
        }

        /// <summary>
        /// Multiplies the first two numbers from stack
        /// </summary>
        public void Multiplication()
        {
            int first = stack.Pop();
            int second = stack.Pop();
            stack.Push(second * first);
        }

        /// <summary>
        /// Divides one number by another from stack
        /// </summary>
        public void Division()
        {
            int first = stack.Pop();
            int second = stack.Pop();
            stack.Push(second / first);
        }

        /// <summary>
        /// Returns the result of the operation from stack
        /// </summary>
        /// <returns></returns>
        public int Result()
        {
            return stack.Pop();
        }
    }
}
