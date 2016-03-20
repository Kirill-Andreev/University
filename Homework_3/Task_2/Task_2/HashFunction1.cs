namespace HashTableNameSpace
{
    /// <summary>
    /// First hash function class
    /// </summary>
    public class HashFunction1 : IHashFunction
    {
        /// <summary>
        /// Returns an integer hash value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="hashConst"></param>
        /// <returns></returns>
        public int HashFunction(int element, int hashConst)
        {
            return element % hashConst;
        }
    }
}
