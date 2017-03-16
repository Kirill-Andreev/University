namespace CalculatorNameSpace
{
    /// <summary>
    /// Interface of stack
    /// </summary>
    public interface IStack
    {
        /// <summary>
        /// Adds new element to stack
        /// </summary>
        /// <param name="value"></param>
        void Push(int value);

        /// <summary>
        /// Returns last element of stack
        /// and delete it
        /// </summary>
        /// <returns></returns>
        int Pop();

        /// <summary>
        /// Checks is stack empty
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();

        /// <summary>
        /// Checks is stack oferflow
        /// </summary>
        /// <returns></returns>
        bool IsOverflowed();
    }
}
