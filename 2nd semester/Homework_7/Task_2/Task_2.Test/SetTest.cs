using Microsoft.VisualStudio.TestTools.UnitTesting;
using SetNameSpace;

namespace Task_2.Test
{
    [TestClass]
    public class SetTest
    {
        [TestMethod]
        public void AddTest()
        {
            Set<int> set = new Set<int>();
            set.Add(1);
            Assert.IsTrue(set.Contains(1));
        }

        [TestMethod]
        public void ContainsTest()
        {
            Set<int> set = new Set<int>();
            set.Add(1);
            Assert.IsTrue(set.Contains(1));
            Assert.IsFalse(set.Contains(2));
        }

        [TestMethod]
        public void RemoveTest()
        {
            Set<int> set = new Set<int>();
            set.Add(1);
            set.Add(2);
            set.Remove(1);
            Assert.IsFalse(set.Contains(1));
            Assert.IsTrue(set.Contains(2));
        }

        [TestMethod]
        public void IntersectTest()
        {
            Set<int> firstSet = new Set<int>(1, 2, 3, 4, 5);
            Set<int> secondSet = new Set<int>(3, 4, 5, 6, 7);
            Set<int> resultSet = firstSet.Intersect(secondSet);
            Assert.IsTrue(resultSet.Contains(3));
            Assert.IsTrue(resultSet.Contains(4));
            Assert.IsTrue(resultSet.Contains(5));
        }

        [TestMethod]
        public void UnionTest()
        {
            Set<int> firstSet = new Set<int>(1, 2, 3, 4, 5);
            Set<int> secondSet = new Set<int>(3, 4, 5, 6, 7);
            Set<int> resultSet = firstSet.Union(secondSet);
            Assert.IsTrue(resultSet.Contains(1));
            Assert.IsTrue(resultSet.Contains(2));
            Assert.IsTrue(resultSet.Contains(3));
            Assert.IsTrue(resultSet.Contains(4));
            Assert.IsTrue(resultSet.Contains(5));
            Assert.IsTrue(resultSet.Contains(6));
            Assert.IsTrue(resultSet.Contains(7));
        }
    }
}
