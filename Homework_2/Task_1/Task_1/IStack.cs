namespace IStackNameSpace
{
    /// <summary>
    /// Interface of stack
    /// </summary>
    interface IStack
    {
        /// <summary>
        /// Checks is stack empty
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// Checks is stack overflowed
        /// </summary>
        /// <returns></returns>
        bool IsOverflowed();

        /// <summary>
        /// Adds new element to stack
        /// </summary>
        /// <param name="newElement"></param>
        void Push(int newElement);

        /// <summary>
        /// Returns last element of stack
        /// and delete it
        /// </summary>
        /// <returns></returns>
        int Pop();
    }
}
