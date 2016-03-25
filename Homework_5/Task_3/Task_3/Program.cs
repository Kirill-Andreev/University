using System;
using System.Collections.Generic;

namespace FoldNameSpace
{
    /// <summary>
    /// Main class
    /// displays the accumulated value
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
            Fold fold = new Fold();
            //fold.FoldFunction(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc * elem);

            Console.WriteLine(fold.FoldFunction(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc * elem));
        }
    }
}
