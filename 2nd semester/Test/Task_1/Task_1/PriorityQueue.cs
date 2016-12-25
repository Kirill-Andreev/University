using System;

namespace QueueNameSpace
{
    /// <summary>
    /// Implementation of priority queue class
    /// </summary>
    public class PriorityQueue
    {
        private int size;
        private Node head;

        /// <summary>
        /// Class of queue element
        /// </summary>
        private class Node
        {
            /// <summary>
            /// Class constructor
            /// </summary>
            /// <param name="value"></param>
            /// <param name="priority"></param>
            public Node(int value, int priority)
            {
                this.Data = value;
                this.Priority = priority;
            }

            /// <summary>
            /// Data field propertie
            /// </summary>
            public int Data { get; set; }

            /// <summary>
            /// Priority field propertie
            /// </summary>
            public int Priority { get; set; }

            /// <summary>
            /// Next field propertie
            /// </summary>
            public Node Next { get; set; }
        }

        /// <summary>
        /// Adds a new element in queue
        /// in accordance with the priority
        /// in descending order
        /// </summary>
        /// <param name="value"></param>
        /// <param name="priority"></param>
        public void EnQueue(int value, int priority)
        {
            Node newNode = new Node(value, priority);

            if (head == null || head.Priority < newNode.Priority)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null && temp.Next.Priority >= newNode.Priority)
                {
                    temp = temp.Next;
                }
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
            size++;
        }

        /// <summary>
        /// Returns the element with the largest priority
        /// and remove it from the queue
        /// </summary>
        /// <returns></returns>
        public int DeQueue()
        {
            if (size == 0)
            {
                throw new EmptyQueueException("The queue is empty!");
            }
            else
            {
                int returnValue = head.Data;
                head = head.Next;
                size--;
                return returnValue;
            }
        }

        /// <summary>
        /// Returns the current size of queue
        /// </summary>
        /// <returns></returns>
        public int GetSize()
        {
            return size;
        }
    }
}
