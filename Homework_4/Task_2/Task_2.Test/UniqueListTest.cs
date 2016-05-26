using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListNameSpace.Test
{
    [TestClass]
    public class UniqueListTest
    {
        private UniqueList list;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
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
            list.Add(0, 1);
            list.Remove(1);
            Assert.AreEqual(0, list.GetSize());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void RemoveFromEmptyList()
        {
            list.Remove(0);
        }

        [TestMethod]
        public void GetFromEmptyList()
        {
            list.Add(0, 1);
            Assert.AreEqual(list.Get(0), 1);
        }

        [TestMethod]
        [ExpectedException(typeof(EqualElementsException))]
        public void AddEqualElementsTest()
        {
            list.Add(0, 1);
            list.Add(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(NonexistentElementException))]
        public void RemoveNonexistentElementTest()
        {
            list.Add(0, 1);
            list.Remove(3);
        }
    }
}
