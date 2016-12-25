namespace HashTableNameSpace
{
    /// <summary>
    /// Second hash function class
    /// </summary>
    public class HashFunction2 : IHashFunction
    {
        /// <summary>
        /// Returns an integer hash value
        /// </summary>
        /// <param name="element"></param>
        /// <param name="hashConst"></param>
        /// <returns></returns>
        public int HashFunction(int element, int hashConst)
        {
            return ((element % hashConst) * (element % hashConst)) % hashConst;
        }
    }
}
