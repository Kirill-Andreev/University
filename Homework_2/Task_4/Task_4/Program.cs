using System;
using CalculatorNameSpace;
using ArrayStackNameSpace;
using ListStackNameSpace;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new ListStack());
            //Calculator calculator = new Calculator(new ArrayStack());

            calculator.Push(2);
            calculator.Push(5);
            calculator.Multiplication();
            Console.WriteLine("Result of multiplication: " + calculator.Result());

            calculator.Push(2);
            calculator.Push(5);
            calculator.Addition();
            Console.WriteLine("Result of addition: " + calculator.Result());

            calculator.Push(2);
            calculator.Push(5);
            calculator.Subtraction();
            Console.WriteLine("Result of substraction: " + calculator.Result());
            
            calculator.Push(2);
            calculator.Push(5);
            calculator.Division();
            Console.WriteLine("Result of division: " + calculator.Result());
        }
    }
}
