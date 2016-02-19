using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        private static int IterativeFibonacci(int n)
        {
            int first = 1;
            int second = 1;
            int sum = 0;
            int i = 2;
            if(n == 1 || n == 2)
            {
                return 1;
            }
            while (i < n)
            {
                sum = first + second;
                first = second;
                second = sum;
                i++; 
            }
            return sum;
        }

        private static int RecursiveFibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter the number of Fibonacci numbers: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci number calculated iteratively: " + IterativeFibonacci(number));
            Console.WriteLine("Fibonacci number calculated recursively: " + RecursiveFibonacci(number));
        }
    }
}
