using System;
using ArrayStackNameSpace;

namespace Task_1
{
    /// <summary>
    /// Main class of the program
    /// displays the contents of the stack,
    /// filled with numbers in a cycle
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            ArrayStack stack = new ArrayStack();
            for (int i = 0; !stack.IsOverflowed(); ++i)
            {
                stack.Push(i);
            }

            for (int i = 0; !stack.IsEmpty(); ++i)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
