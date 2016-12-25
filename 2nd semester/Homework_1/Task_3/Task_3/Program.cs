using System;

namespace Task_3
{
    /// <summary>
    /// Class Program
    /// main class of the program displays
    /// the array of random numbers before sorting,
    /// sorts this array 
    /// and displays it after sorting
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method QuickSort()
        /// sorts the array of integers
        /// </summary>
        /// <param name="array"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        private static void QuickSort(int[] array, int first, int last)
        {
            int prop = array[(last - first) / 2 + first];
            int i = first;
            int j = last;
            while (i <= j)
            {
                while ((array[i] < prop) && (i <= last))
                {
                    ++i;
                }

                while ((array[j] > prop) && (j >= first))
                {
                    --j;
                }

                int temp;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (j > first)
            {
                QuickSort(array, first, j);
            }

            if (i < last)
            {
                QuickSort(array, i, last);
            }
        }

        /// <summary>
        /// Method Main()
        /// is the entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rand.Next(-100, 100);
            }

            Console.Write("Array before sorting: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine();
            Console.Write("Array after sorting: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
