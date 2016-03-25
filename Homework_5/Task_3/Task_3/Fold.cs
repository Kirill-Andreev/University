using System;
using System.Collections.Generic;

namespace FoldNameSpace
{
    /// <summary>
    /// 
    /// </summary>
    public class Fold
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="initialValue"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public int FoldFunction(List<int> list, int initialValue, Func<int, int, int> function)
        {
            int store = initialValue;
            for (int i = 0; i < list.Count; ++i)
            {
                store = function(store, list[i]);
            }
            return store;
        }
    }
}
