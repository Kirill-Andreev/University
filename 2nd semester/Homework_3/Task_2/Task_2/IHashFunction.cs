namespace HashTableNameSpace
{
    /// <summary>
    /// Interface of hash function
    /// </summary>
    public interface IHashFunction
    {
        /// <summary>
        /// Returns an integer hash value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="hashConst"></param>
        /// <returns></returns>
        int HashFunction(int value, int hashConst);
    }
}