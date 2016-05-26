using System.Collections.Generic;

namespace GenericNameSpace
{
    /// <summary>
    /// Generic list class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Adds the element to the end of list
        /// </summary>
        /// <param name="element"></param> 
        void Add(T element);

        /// <summary>
        /// Remove the element from list
        /// </summary>
        /// <param name="element"></param>
        void Remove(T element);

        /// <summary>
        /// Checks is element contains in the list
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool Contains(T element);
    }
}
