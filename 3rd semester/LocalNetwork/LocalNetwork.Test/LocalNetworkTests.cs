using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocalNetworkNameSpace
{
    [TestClass]
    public class LocalNetworkTests
    {
        private bool[,] matrix;
        private List<Computer> computers;
        OperationSystem windows10 = new OperationSystem(40);
        OperationSystem linux = new OperationSystem(30);
        OperationSystem mac = new OperationSystem(60);
        OperationSystem windows2000 = new OperationSystem(20);
        OperationSystem dieHard = new OperationSystem(2);

        [TestMethod]
        public void NetworkInfectionTest()
        {
            matrix = new bool[,] { { false, true, true, false }, { true, false, false, true }, { true, false, false, true }, { false, true, true, false } };
            computers = new List<Computer>
            {
                new Computer(true, linux),
                new Computer(false, mac),
                new Computer(false, windows10),
                new Computer(true, windows2000)
            };

            var netWork = new LocalNetwork(computers, matrix);
            netWork.NetworkInfection();
            for (int i = 0; i < computers.Count; ++i)
            {
                Assert.IsTrue(computers[i].IsInfected);
            }
        }

        [TestMethod]
        public void NetworkInfectionHardTest()
        {
            matrix = new bool[,] { { false, true, true, false }, { true, false, false, true }, { true, false, false, true }, { false, true, true, false } };
            computers = new List<Computer>
            {
                new Computer(true, dieHard),
                new Computer(false, dieHard),
                new Computer(false, dieHard),
                new Computer(false, dieHard)
            };

            var netWork = new LocalNetwork(computers, matrix);
            netWork.NetworkInfection();
            for (int i = 0; i < computers.Count; ++i)
            {
                Assert.IsTrue(computers[i].IsInfected);
            }
        }

        [TestMethod]
        public void NetworkInfectionWithoutVirusesTest()
        {
            matrix = new bool[,] { { false, true, true, false }, { true, false, false, true }, { true, false, false, true }, { false, true, true, false } };
            computers = new List<Computer>
            {
                new Computer(false, dieHard),
                new Computer(false, dieHard),
                new Computer(false, dieHard),
                new Computer(false, dieHard)
            };

            var netWork = new LocalNetwork(computers, matrix);
            netWork.NetworkInfection();
            for (int i = 0; i < computers.Count; ++i)
            {
                Assert.IsFalse(computers[i].IsInfected);
            }
        }

        [TestMethod]
        public void CoupledComputerInfectionTest()
        {
            mac.RiskOfInfection = 100;
            matrix = new bool[,] { { false, true, false }, { true, false, true }, { false, true, false }};
            computers = new List<Computer>
            {
                new Computer(true, linux),
                new Computer(false, mac),
                new Computer(false, windows10),
            };
            var netWork = new LocalNetwork(computers, matrix);
            netWork.Turn();
            Assert.IsTrue(computers[0].IsInfected);
            Assert.IsTrue(computers[1].IsInfected);
            Assert.IsFalse(computers[2].IsInfected);
        }
    }
}
