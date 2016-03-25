using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueNameSpace;

namespace Task_1.Test
{
    [TestClass]
    public class PriorityQueueTest
    {
        private PriorityQueue queue;

        [TestInitialize]
        public void Initialize()
        {
            queue = new PriorityQueue();
        }

        [TestMethod]
        public void EnqueueTest()
        {
            queue.EnQueue(1, 1);
            queue.EnQueue(2, 2);
            queue.EnQueue(3, 3);
            
            for (int i = 0; i < queue.GetSize(); ++i)
            {
                Assert.AreEqual(queue.DeQueue(), queue.GetSize() + 1);
            }
        }

        [TestMethod]
        public void DequeueTest()
        {
            queue.EnQueue(1, 1);
            queue.EnQueue(2, 2);
            Assert.AreEqual(queue.DeQueue(), 2);
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyQueueException))]
        public void RemoveFromEmptyQueueTest()
        {
            queue.DeQueue();
        }
    }
}
