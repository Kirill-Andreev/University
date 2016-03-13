namespace ListNameSpace.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ListNameSpace;

    [TestClass]
    public class ListTest
    {
        private List list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List();
        }

        [TestMethod]
        public void AddTest()
        {
            list.Add(0, 1);
            Assert.AreEqual(1, list.Get(0));
        }

        [TestMethod]
        public void RemoveTest()
        {
            list.Remove(0);
            Assert.AreEqual(0, list.GetSize());
        }

        [TestMethod]
        public void RemoveFromEmtyList()
        {
            list.Remove(0);
        }

        [TestMethod]
        public void GetFromEmtyList()
        {
            list.Get(0);
        }
    }
}
