using IHashTableNameSpace;
using ListNameSpace;

namespace HashTableNameSpace
{
    /// <summary>
    /// Hash table class
    /// implements methods declarated in interface
    /// </summary>
    public class HashTable : IHashTable
    {
        private List[] hashTable;
        private int hashTableSize;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="size"></param>
        public HashTable(int size)
        {
            hashTableSize = size;
            hashTable = new List[hashTableSize];
            for (int i = 0; i < hashTableSize; ++i)
            {
                hashTable[i] = new List();
            }
        }

        /// <summary>
        /// Returns the remainder of the division
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private int HashFunction(int element)
        {
            return element % hashTableSize;
        }

        public void Add(int element)
        {
            hashTable[HashFunction(element)].Add(element);
        }

        public void Remove(int element)
        {
            hashTable[HashFunction(element)].Remove(element);
        }

        public bool Check(int element)
        {
            if (hashTable[HashFunction(element)].Get(element) == element)
            {
                return true;
            }
            return false;
        }
    }
}
