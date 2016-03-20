using System;

namespace HashTableNameSpace
{
    /// <summary>
    /// Main class of the programm
    /// displays message about the presence 
    /// of an elements in hash table
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int size = 5;
            HashTable hashTable = new HashTable(size);
            hashTable.Add(5);
            hashTable.Add(6);
            hashTable.Add(7);
            hashTable.Add(8);
            hashTable.Add(9);
            hashTable.Add(12);
            hashTable.Add(17);
            if (hashTable.Check(7))
            {
                Console.WriteLine("The element is found");
            }
            else
            {
                Console.WriteLine("The element not found");
            }

            hashTable.Remove(12);
            if(hashTable.Check(12))
            {
                Console.WriteLine("The element is found");
            }
            else
            {
                Console.WriteLine("The element not found");
            }

            if (hashTable.Check(17))
            {
                Console.WriteLine("The element is found");
            }
            else
            {
                Console.WriteLine("The element not found");
            }
        }
    }
}
