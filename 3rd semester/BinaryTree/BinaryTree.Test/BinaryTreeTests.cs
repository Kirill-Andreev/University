using BinaryTreeNameSpace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTree.Test
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void AddTest()
        {
            var tree = new BinaryTree<int>();
            tree.Add(50);
        }
        
        [TestMethod]
        public void ContainsTest()
        {
            var tree = new BinaryTree<int>();
            tree.Add(50);
            Assert.IsTrue(tree.Contains(50));
            Assert.IsFalse(tree.Contains(10));
        }

        [TestMethod]
        public void RemoveTest()
        {
            var tree = new BinaryTree<int>();
            tree.Add(50);
            tree.Add(10);
            tree.Add(25);
            tree.Add(3);
            tree.Remove(25);
            Assert.IsFalse(tree.Contains(25));
        }

        [TestMethod]
        public void RemoveFromRootTest()
        {
            var tree = new BinaryTree<int>();
            tree.Add(50);
            tree.Add(10);
            tree.Add(25);
            tree.Add(3);
            tree.Remove(50);
            Assert.IsFalse(tree.Contains(50));
        }

        [TestMethod]
        public void RemoveNodeWithTwoSonsTest()
        {
            var tree = new BinaryTree<int>();
            tree.Add(50);
            tree.Add(10);
            tree.Add(25);
            tree.Add(3);
            tree.Add(5);
            tree.Remove(10);
            Assert.IsFalse(tree.Contains(10));
            Assert.IsTrue(tree.Contains(3));
            Assert.IsTrue(tree.Contains(5));
        }

        [TestMethod]
        public void RemoveNodeWithOneSonTest()
        {
            var tree = new BinaryTree<int>();
            tree.Add(50);
            tree.Add(10);
            tree.Add(25);
            tree.Add(3);
            tree.Remove(10);
            Assert.IsFalse(tree.Contains(10));
            Assert.IsTrue(tree.Contains(3));
        }

        [TestMethod]
        public void EnumeratorTest()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            int j = 0;
            foreach (int element in tree)
            {
                Assert.IsTrue(tree.Contains(element));
                ++j;
            }
        }
    }
}
