using System;
using System.Collections.Generic;

namespace MapNameSpace
{
    /// <summary>
    /// The main class
    /// displays the modified list 
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
            Map map = new Map();
            List<int> modifiedList = map.MapFunction(new List<int>() { 1, 2, 3 }, function => function * 2);

            for (int i = 0; i < modifiedList.Count; ++i)
            {
                Console.Write(modifiedList[i] + " ");
            }
        }
    }
}
