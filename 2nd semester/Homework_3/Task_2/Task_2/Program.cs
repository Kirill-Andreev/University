using System;

namespace HashTableNameSpace
{
    /// <summary>
    /// Main class of the programm
    /// displays message about the presence 
    /// of an elements in hash table
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            IHashFunction hashFunction;
            HashTable hashTable;
            Console.WriteLine("Enter:\n 1 to use first hash function\n 2 to use second hash function");
            uint enter = Convert.ToUInt16(Console.ReadLine());
            
            while (enter != 1 && enter != 2)
            {
                Console.WriteLine("Enter the correct number!");
                enter = Convert.ToUInt16(Console.ReadLine());
            }

            if (enter == 1)
            {
                hashFunction = new HashFunction1();
            }
            else
            {
                hashFunction = new HashFunction2();
            }

            int size = 5;
            hashTable = new HashTable(size, hashFunction);
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
            if (hashTable.Check(12))
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
