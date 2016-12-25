namespace BinaryTreeNameSpace
{
    /// <summary>
    /// Generic binary tree interface
    /// </summary>
    public interface IBinaryTree<T>
    {
        /// <summary>
        /// Add element to tree
        /// </summary>
        /// <param name="element"></param>
        void Add(T element);

        /// <summary>
        /// Remove element from tree
        /// </summary>
        /// <param name="element"></param>
        bool Remove(T element);

        /// <summary>
        /// Check is element contains in tree
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        bool Contains(T element);
    }
}
