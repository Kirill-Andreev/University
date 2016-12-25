namespace GenericNameSpace
{
    /// <summary>
    /// Generic stack class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStack<T>
    {
        /// <summary>
        /// Push the element in stack
        /// </summary>
        /// <param name="element"></param>
        void Push(T element);

        /// <summary>
        /// Returns the element from the head of the stack
        /// and remove it
        /// </summary>
        /// <returns></returns>
        T Pop();

        /// <summary>
        /// Checks is stack is empty
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
    }
}
