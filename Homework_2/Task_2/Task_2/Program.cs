using System;
using ExceptionNamespace;

namespace ListNameSpace
{
    /// <summary>
    /// Main class of the program
    /// displays the results of operations on list
    /// </summary>
    class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List list = new List();
            try
            {
                list.Add(0, 1);
                list.Add(1, 3);
                list.Add(1, 2);
                list.Add(3, 4);
                int count = list.GetSize();
                for (int i = 0; i < count; ++i)
                {
                    Console.Write(list.Get(i) + " ");
                }

                Console.WriteLine();
                list.Remove(0);
                list.Remove(1);
                list.Remove(1);
                list.Remove(0);
                list.Remove(10);
                count = list.GetSize();
                for (int i = 0; i < count; ++i)
                {
                    Console.Write(list.Get(i) + " ");
                }

                Console.WriteLine();
            }
            catch (IncorrectPositionException e)
            {
                Console.WriteLine(e);
            }
            catch(EmptyListException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
