using System;

namespace ListNameSpace
{
    /// <summary>
    /// Main class of the program
    /// displays the results of operations on list
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            UniqueList list = new UniqueList();
            try
            {
                list.Add(0, 1);
                list.Add(1, 1);
            }
            catch (EqualElementsException e)
            {
                Console.WriteLine(e);
            }
            try
            {
                list.Remove(9);
            }
            catch (NonexistentElementException e)
            {
                Console.WriteLine(e);
            }

            int counter = list.GetSize();

            for (int i = 0; i < counter; ++i)
            {
                Console.Write("List: " + list.Get(i));
            }
            Console.WriteLine();
        }
    }
}
