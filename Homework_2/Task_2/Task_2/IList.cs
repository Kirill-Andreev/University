namespace IListNameSpace
{
    /// <summary>
    /// Interface of list
    /// </summary>
    interface IList
    {
        /// <summary>
        /// Adds a new element 
        /// at the specified position in the list
        /// </summary>
        /// <param name="newElement"></param>
        void Add(int position, int newElement);

        /// <summary>
        /// Removes the element 
        /// from the specified position of list
        /// </summary>
        /// <param name="position"></param>
        void Remove(int position);

        /// <summary>
        /// Returns the element 
        /// from the specified position of the list
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        int Get(int position);

        /// <summary>
        /// Returns the size of list
        /// </summary>
        /// <returns></returns>
        int GetSize();
    }
}
