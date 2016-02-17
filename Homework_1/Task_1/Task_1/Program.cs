using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
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

        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of recursive factorial: " + RecursiveFactorial(number));
            Console.WriteLine("Result of iterative factorial: " + IterativeFactorial(number));
        }
    }
}
