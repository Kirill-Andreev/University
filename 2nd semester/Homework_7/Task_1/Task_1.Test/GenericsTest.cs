using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericNameSpace;

namespace Task_1.Test
{
    [TestClass]
    public class GenericsTest
    {
        [TestMethod]
        public void ListAddTest()
        {
            var list = new List<int>();
            list.Add(1);
        }

        [TestMethod]
        public void ListContainsTest()
        {
            var list = new List<char>();
            list.Add('o');
            Assert.IsTrue(list.Contains('o'));
            Assert.IsFalse(list.Contains('l'));
        }

        [TestMethod]
        public void ListRemoveTest()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Remove(2);
            Assert.IsFalse(list.Contains(2));
        }

        [TestMethod]
        public void ListEnumeratorTest()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            int counter = 1;
            foreach(int element in list)
            {
                Assert.AreEqual(counter, element);
                counter++;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyListException))]
        public void RemoveFromEmptyListTest()
        {
            var list = new List<int>();
            list.Remove(1);
        }

        [TestMethod]
        public void StackPopTest()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void StackPushTest()
        {
            var stack = new Stack<int>();
            stack.Push(1);
        }

        [TestMethod]
        public void StackIsEmptyTest()
        {
            var stack = new Stack<int>();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyStackException))]
        public void PopFromEmptyStack()
        {
            var stack = new Stack<int>();
            stack.Pop();
        }
    }
}
