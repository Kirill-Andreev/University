using System;
using IStackNameSpace;

namespace CalculatorNameSpace
{
    class Calculator
    {
        private IStack stack;

        public Calculator(IStack stack)
        {
            this.stack = stack;
        }

        public void Push(int value)
        {
            stack.Push(value);
        }

        public void Addition()
        {
            stack.Push(stack.Pop() + stack.Pop());
        }

        public void Subtraction()
        {
            stack.Push(stack.Pop() - stack.Pop());
        }

        public void Multiplication()
        {
            stack.Push(stack.Pop() * stack.Pop());
        }

        public void Division()
        {
            int first = stack.Pop();
            int second = stack.Pop();
            stack.Push(first / second);
        }

        public int Result()
        {
            if (stack.IsEmpty())
            {
                return Int32.MinValue;
            }
            return stack.Pop();
        }
    }
}
