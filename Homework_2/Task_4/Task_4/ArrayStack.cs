﻿using IStackNameSpace;

namespace ArrayStackNameSpace
{
    /// <summary>
    /// Array stack class implements the methods 
    /// declared in the interface
    /// </summary>
    public class ArrayStack : IStack
    {
        private int[] stack;
        private const int stackSize = 100;
        private int ptr;

        /// <summary>
        /// Class constructor
        /// </summary>
        public ArrayStack()
        {
            stack = new int[stackSize];
        }

        public void Push(int value)
        {
            ptr++;
            stack[ptr] = value;
        }

        public int Pop()
        {
            return stack[ptr--];
        }

        public bool IsEmpty()
        {
            return ptr == 0;
        }

        public bool IsOverflowed()
        {
            return ptr == (stackSize - 1);
        }
    }
}
