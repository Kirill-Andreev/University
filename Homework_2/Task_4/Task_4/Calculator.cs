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
            try
            {
                stack.Push(value);
            }
            catch (OverFlowStackException)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds the first two numbers from stack
        /// </summary>
        public void Addition()
        {
            try
            {
                int first = stack.Pop();
                int second = stack.Pop();
                stack.Push(second + first);
            }
            catch (EmptyStackException)
            {
                throw;
            }
            catch (OverFlowStackException)
            {
                throw;
            }
        }

        /// <summary>
        /// Subtracts one number from another from stack
        /// </summary>
        public void Subtraction()
        {
            try
            {
                int first = stack.Pop();
                int second = stack.Pop();
                stack.Push(second - first);
            }
            catch (EmptyStackException)
            {
                throw;
            }
            catch (OverFlowStackException)
            {
                throw;
            }
        }

        /// <summary>
        /// Multiplies the first two numbers from stack
        /// </summary>
        public void Multiplication()
        {
            try
            {
                int first = stack.Pop();
                int second = stack.Pop();
                stack.Push(second * first);
            }
            catch (EmptyStackException)
            {
                throw;
            }
            catch (OverFlowStackException)
            {
                throw;
            }
        }

        /// <summary>
        /// Divides one number by another from stack
        /// </summary>
        public void Division()
        {
            try
            {
                int first = stack.Pop();
                int second = stack.Pop();
                if (first == 0)
                {
                    throw new DivideByZeroException();
                }
                try
                {
                    stack.Push(second / first);
                }
                catch (DivideByZeroException)
                {
                    stack.Push(Int32.MinValue);
                    throw;
                }
            }
            catch (EmptyStackException)
            {
                throw;
            }
            catch (OverFlowStackException)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns the result of the operation from stack
        /// </summary>
        /// <returns></returns>
        public int Result()
        {
            int result = Int32.MinValue;
            try
            {
                result = stack.Pop();
            }
            catch (EmptyStackException)
            {
                throw;
            }
            return result;
        }
    }
}
