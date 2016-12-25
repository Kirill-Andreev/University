using System;
using System.Collections.Generic;

namespace FilterNameSpace
{
    /// <summary>
    /// Class that implements
    /// the method that filtered the list
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Returns the filtered by function list
        /// </summary>
        /// <param name="list"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public List<int> FilterFunction(List<int> list, Func<int, bool> function)
        {
            List<int> filteredList = new List<int>();

            for (int i = 0; i < list.Count; ++i)
            {
                if (function(list[i]))
                {
                    filteredList.Add(list[i]);
                }
            }
            return filteredList;
        }
    }
}
