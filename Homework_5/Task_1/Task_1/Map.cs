using System;
using System.Collections.Generic;


namespace MapNameSpace
{
    /// <summary>
    /// Class that implements
    /// the method that modified the list
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Returns modified by the function list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public List<int> MapFunction(List<int> list, Func<int, int> function)
        {
            List<int> modifiedList = new List<int>();

            for (int i = 0; i < list.Count; ++i)
            {
                modifiedList.Add(function(list[i]));
            }
            return modifiedList;
        }
    }
}
