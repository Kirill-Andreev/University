using System;

namespace HashTableNameSpace
{
    /// <summary>
    /// Hash table class
    /// implements methods declarated in interface
    /// </summary>
    public class HashTable
    {
        private List[] hashTable;
        private int hashTableSize;
        private int numberOfElements;
        private IHashFunction hashFunction;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="size"></param>
        public HashTable(int size, IHashFunction hashFunction)
        {
            this.hashFunction = hashFunction;
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
            return hashFunction.HashFunction(element, hashTableSize);
        }

        /// <summary>
        /// Adds new element in hash table
        /// </summary>
        /// <param name="element"></param>
        public void Add(int element)
        {
            hashTable[HashFunction(element)].Add(element);
            numberOfElements++;
        }

        /// <summary>
        /// Removes specified element 
        /// from hash table
        /// </summary>
        /// <param name="element"></param>
        public void Remove(int element)
        {
            try
            {
                hashTable[HashFunction(element)].Remove(element);
                numberOfElements--;
            }
            catch (EmptyListException e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Checks if element exists in hash table
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Check(int element)
        {
            try
            {
                return (hashTable[HashFunction(element)].Get(element) == element);
            }
            catch(EmptyListException)
            {
                return false;
            }
        }
    }
}
