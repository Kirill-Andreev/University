using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTableNameSpace.Test
{
    [TestClass]
    public class HashTableTest
    {
        private HashTable hashTable1;
        private HashTable hashTable2;
        private HashFunction1 hashFunction1;
        private HashFunction2 hashFunction2;

        [TestInitialize]
        public void Initialize()
        {
            hashFunction1 = new HashFunction1();
            hashFunction2 = new HashFunction2();
            hashTable1 = new HashTable(5, hashFunction1);
            hashTable2 = new HashTable(5, hashFunction2);
        }

        [TestMethod]
        public void AddTest1()
        {
            hashTable1.Add(6);
            Assert.IsTrue(hashTable1.Check(6));
        }

        [TestMethod]
        public void AddTest2()
        {
            hashTable2.Add(6);
            Assert.IsTrue(hashTable2.Check(6));
        }

        [TestMethod]
        public void RemoveTest1()
        {
            hashTable1.Add(8);
            hashTable1.Add(6);
            hashTable1.Remove(6);
            Assert.IsFalse(hashTable1.Check(6));
        }

        [TestMethod]
        public void RemoveTest2()
        {
            hashTable2.Add(8);
            hashTable2.Add(6);
            hashTable2.Remove(6);
            Assert.IsFalse(hashTable2.Check(6));
        }

        [TestMethod]
        public void CheckTest1()
        {
            hashTable1.Add(1);
            Assert.IsTrue(hashTable1.Check(1));
        }

        [TestMethod]
        public void CheckTest2()
        {
            hashTable2.Add(1);
            Assert.IsTrue(hashTable2.Check(1));
        }
    }
}
