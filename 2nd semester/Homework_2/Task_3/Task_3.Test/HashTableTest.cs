using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTableNameSpace;

namespace HashTableNameSpace.Test
{
    [TestClass]
    public class HashTableTest
    {
        private HashTable hashTable;

        [TestInitialize]
        public void Initialize()
        {
            hashTable = new HashTable(5);
        }

        [TestMethod]
        public void AddTest()
        {
            hashTable.Add(6);
            Assert.IsTrue(hashTable.Check(6));
        }

        [TestMethod]
        public void RemoveTest()
        {
            hashTable.Add(8);
            hashTable.Add(6);
            hashTable.Remove(6);
            Assert.IsFalse(hashTable.Check(6));
        }

        [TestMethod]
        public void RemoveFirstElement()
        {
            hashTable.Add(5);
            hashTable.Remove(5);
            Assert.IsFalse(hashTable.Check(5));
        }

        [TestMethod]
        public void CheckTest()
        {
            hashTable.Add(1);
            Assert.IsTrue(hashTable.Check(1));
        }
    }
}
