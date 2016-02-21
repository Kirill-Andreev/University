using System;

namespace Task_5
{
    /// <summary>
    /// Class Program
    /// main program displays matrix 
    /// with sorted columns
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method SortMatrixByColumns()
        /// sorts the columns of the matrix
        /// by the first element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        private static void SortMatrixByColumns(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); ++i)
            {
                for (int j = array.GetLength(1) - 1; j > i; --j)
                {
                    if (array[0, j - 1] > array[0, j])
                    {
                        for (int n = 0; n < array.GetLength(0); ++n)
                        {
                            int temp = array[n, j - 1];
                            array[n, j - 1] = array[n, j];
                            array[n, j] = temp;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method MatrixOutput()
        /// prints the elements of the matrix 
        /// row by row
        /// </summary>
        /// <param name="array"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        private static void MatrixOutput(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method Main()
        /// is the entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows of matrix: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns of matrix: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, columns];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    array[i, j] = rand.Next(0, 100);
                }
            }

            Console.WriteLine("Our matrix: ");
            MatrixOutput(array);
            Console.WriteLine("Sorted matrix: ");
            SortMatrixByColumns(array);
            MatrixOutput(array);
        }
    }
}
