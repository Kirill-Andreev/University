﻿namespace ListNameSpace.Test
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
            list.Add(0, 1);
            list.Remove(0);
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
    }
}
