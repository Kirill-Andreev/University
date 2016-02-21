using System;

namespace Task_4
{
    /// <summary>
    /// Class Program
    /// main program displays the entire matrix
    /// and then its elements in a spiral
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method OutputInSpiral()
        /// prints the elements of a matrix in a spiral 
        /// starting from the center
        /// </summary>
        /// <param name="array"></param>
        /// <param name="dim"></param>
        private static void OutputInSpiral(int[,] array, int dim)
        {
            int i = dim / 2;
            int j = dim / 2;
            int turns = 0;
            for (int n = 0; n < dim * dim; ++n)
            {
                Console.Write(array[i, j] + " ");
                switch (turns % 4)
                {
                    case 0:
                        i--;                               // up
                        if (j - 1 == i)
                        {
                            turns++;
                        }
                        break;
                    case 1:
                        j++;                               // right
                        if (dim - j - 1 == i)
                        {
                            turns++;
                        }
                        break;
                    case 2:
                        i++;                               // down
                        if (dim - j == dim - i)
                        {
                            turns++;
                        }
                        break;
                    case 3:
                        j--;                               // left
                        if (i == dim - j - 1)
                        {
                            turns++;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Method NormalOutput()
        /// prints the elements of the matrix 
        /// row by row
        /// </summary>
        /// <param name="array"></param>
        /// <param name="dim"></param>
        private static void NormalOutput(int[,] array)
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
            Console.WriteLine("Enter the dimension of matrix: ");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[dim, dim];
            Random rand = new Random();
            for (int i = 0; i < dim; ++i)
            {
                for (int j = 0; j < dim; ++j)
                {
                    array[i, j] = rand.Next(0, 100);
                }
            }
            Console.WriteLine("Our matrix: ");
            NormalOutput(array);
            Console.Write("Matrix elements derived in a spiral: ");
            OutputInSpiral(array, dim);
        }
    }
}
