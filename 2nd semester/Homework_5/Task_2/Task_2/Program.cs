using System;
using System.Collections.Generic;

namespace FilterNameSpace
{
    /// <summary>
    /// The main class
    /// displays the filtered list 
    /// after using function
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Filter filter = new Filter();
            List<int> filteredList = filter.FilterFunction(new List<int>() { 1, 2, 3, 4, 5 }, function => function % 2 == 0);

            for (int i = 0; i < filteredList.Count; ++i)
            {
                Console.Write(filteredList[i] + " ");
            }
        }
    }
}
