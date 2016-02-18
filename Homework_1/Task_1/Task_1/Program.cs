using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Class Program
    /// main class of the program displays the factorial of a number n
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method RecursiveFactorial()
        /// recursively calculates the factorial of a number and returns it
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            return n * RecursiveFactorial(n - 1);
        }
        /// <summary>
        /// Method IterativeFactorial()
        /// iteratively calculates the factorial of a number and returns it
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int IterativeFactorial(int n)
        {
            int result = 1;
            if (n == 0)
            {
                return 1;
            }
            if (n == 1)
            {
                return 1;
            }
            for (int i = 1; i <= n; ++i)
            {
                result *= i;
            }
            return result;
        }
        /// <summary>
        /// Method Main()
        /// is the entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of recursive factorial: " + RecursiveFactorial(number));
            Console.WriteLine("Result of iterative factorial: " + IterativeFactorial(number));
        }
    }
}
