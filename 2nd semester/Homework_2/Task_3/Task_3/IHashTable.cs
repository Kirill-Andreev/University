namespace HashTableNameSpace
{
    /// <summary>
    /// Interface of hash table
    /// </summary>
    interface IHashTable
    {
        /// <summary>
        /// Adds new element in hash table
        /// </summary>
        /// <param name="element"></param>
        void Add(int element);

        /// <summary>
        /// Removes specified element 
        /// from hash table
        /// </summary>
        /// <param name="element"></param>
        void Remove(int element);

        /// <summary>
        /// Checks if element exists in hash table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool Check(int element);
    }
}
