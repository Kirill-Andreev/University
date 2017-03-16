using System;

namespace CalculatorNameSpace
{
    /// <summary>
    /// Main class of the programm
    /// returns the result of operations
    /// on stack numbers 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(new ListStack());
            //Calculator calculator = new Calculator(new ArrayStack());
            try
            {
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
                calculator.Push(0);
                try
                {
                    calculator.Division();
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("Result of division: " + calculator.Result());
            }
            catch (OverFlowStackException e)
            {
                Console.WriteLine(e);
            }
            catch (EmptyStackException e)
            {
                Console.WriteLine(e);
            }   
        }
    }
}
