using System.Collections.Generic;
using System.Linq;

namespace SetNameSpace
{
    /// <summary>
    /// Implementation of the class Set
    /// without repeating elements
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Set<T>
    {
        private List<T> set;

        /// <summary>
        /// Class constructor without arguments
        /// </summary>
        public Set()
        {
            this.set = new List<T>();
        }

        public Set(params T[] args)
            : this()
        {
            set.AddRange(args);
        }

        /// <summary>
        /// Creates a set consisting of elements 
        /// of the specified collection
        /// </summary>
        /// <param name="mas"></param>
        public Set(IEnumerable<T> mas)
            : this()
        {
            set.AddRange(mas);
        }

        /// <summary>
        /// Adds an unique elements to the set
        /// </summary>
        /// <param name="element"></param>
        public void Add(T element)
        {
            if (!set.Contains(element))
            {
                set.Add(element);
            }
        }

        /// <summary>
        /// Removes an element from set
        /// </summary>
        /// <param name="element"></param>
        public void Remove(T element)
        {
            set.Remove(element);
        }

        /// <summary>
        /// Checks whether an element is in the set
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element)
        {
            return set.Contains(element);
        }

        public List<T> GetSet()
        {
            return set;
        }

        /// <summary>
        /// Returns the intersection of two sets
        /// </summary>
        /// <param name="secondSet"></param>
        /// <returns></returns>
        public Set<T> Intersect(Set<T> secondSet)
        {
            return new Set<T>(set.Intersect(secondSet.set));
        }

        /// <summary>
        /// Returns the result of combining of two sets
        /// </summary>
        /// <param name="secondSet"></param>
        /// <returns></returns>
        public Set<T> Union(Set<T> secondSet)
        {
            return new Set<T>(set.Union(secondSet.set));
        }
    }
}
