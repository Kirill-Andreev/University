using System;
using System.Collections.Generic;

namespace LocalNetworkNameSpace
{
    /// <summary>
    /// Implementation of the local network
    /// </summary>
    public class LocalNetwork
    {
        List<Computer> allComputers;
        private Random random = new Random();
        private bool[,] adjacencyMatrix;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="computers"></param>
        /// <param name="matrix"></param>
        public LocalNetwork(List<Computer> computers, bool[,] matrix)
        {
            allComputers = computers;
            adjacencyMatrix = matrix;
        }

        /// <summary>
        /// Step of network
        /// </summary>
        public void Turn()
        {
            for (int i = 0; i < allComputers.Count; ++i)
            {
                if (allComputers[i].IsInfected)
                {
                    for (int j = i; j < allComputers.Count; ++j)
                    {
                        if (adjacencyMatrix[i, j] && !allComputers[j].IsInfected)
                        {
                            if (random.Next(1, 100) <= allComputers[j].GetRiskOfIfection())
                            {
                                allComputers[j].IsInfected = true;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Current status of computers
        /// </summary>
        public void NetworkStatus()
        {
            for (int i = 0; i < allComputers.Count; ++i)
            {
                Console.WriteLine("Computer: " + i + " Infected: " + allComputers[i].IsInfected);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Step-by-step infection of network
        /// until all computers will become infected
        /// </summary>
        public void NetworkInfection()
        {
            int i = 0;
            Console.WriteLine("Network status after " + i + " turn(s)");
            i++;
            NetworkStatus();
            while (!Check())
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Network status after " + i + " turn(s)");
                Turn();
                NetworkStatus();
                ++i;
            }
        }

        private bool Check()
        {
            int count = 0;
            for (int i = 0; i < allComputers.Count; ++i)
            {
                if (allComputers[i].IsInfected)
                {
                    ++count;
                }
            }
            return count == allComputers.Count || count == 0;
        }
    }
}
