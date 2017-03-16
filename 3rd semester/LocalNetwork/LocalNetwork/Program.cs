using System.Collections.Generic;

namespace LocalNetworkNameSpace
{
    /// <summary>
    /// The main class of the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var windows10 = new OperationSystem(40);
            var linux = new OperationSystem(30);
            var mac = new OperationSystem(60);
            var windows2000 = new OperationSystem(20);
            bool[,] matrix = new bool[,] { { false, true, true, false }, { true, false, false, true }, { true, false, false, true }, { false, true, true, false } };
            var computers = new List<Computer>
            {
                new Computer(true, linux),
                new Computer(false, mac),
                new Computer(false, windows10),
                new Computer(true, windows2000)
            };

            var netWork = new LocalNetwork(computers, matrix);
            netWork.NetworkInfection();
        }
    }
}
