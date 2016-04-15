using System;
using System.Collections.Generic;

namespace FoldNameSpace
{
    /// <summary>
    /// Class with Fold method
    /// that returns the accumulated value
    /// after using the Func function
    /// </summary>
    public class Fold
    {
        /// <summary>
        /// Sequentially uses the Func function 
        /// to each element of list and returns
        /// the accumulated value
        /// </summary>
        /// <param name="list"></param>
        /// <param name="initialValue"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public int FoldFunction(List<int> list, int initialValue, Func<int, int, int> function)
        {
            int storage = initialValue;
            for (int i = 0; i < list.Count; ++i)
            {
                storage = function(storage, list[i]);
            }
            return storage;
        }
    }
}
