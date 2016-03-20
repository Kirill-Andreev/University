using ExceptionNameSpace;

namespace ListNameSpace
{
    /// <summary>
    /// List class implements the methods 
    /// declared in the interface
    /// </summary>
    public class List
    {
        private ListElement head;

        /// <summary>
        /// Class of list element
        /// </summary>
        private class ListElement
        {
            /// <summary>
            /// Class constructor
            /// </summary>
            /// <param name="value"></param>
            public ListElement(int value)
            {
                this.Data = value;
            }

            /// <summary>
            /// Data field properties
            /// </summary>
            public int Data { get; set; }

            /// <summary>
            /// Next field properties
            /// </summary>
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// Adds new element to head of list
        /// </summary>
        /// <param name="newElement"></param>
        public void Add(int newElement)
        {
            ListElement newListElement = new ListElement(newElement);
            newListElement.Next = head;
            head = newListElement;
        }

        /// <summary>
        /// Removes specified element from list
        /// </summary>
        /// <param name="element"></param>
        public void Remove(int element)
        {
            if (head == null)
            {
                throw new EmptyListException();
            }

            if (head.Data == element)
            {
                head = head.Next;
            }
            else
            {
                ListElement temp1 = head;
                ListElement temp2 = head;

                temp1 = temp1.Next;
                while (temp1.Next != null && temp1.Data != element)
                {
                    temp1 = temp1.Next;
                    temp2 = temp2.Next;
                }
                temp2.Next = temp1.Next;
            }
        }

        /// <summary>
        /// Returns the specified element
        /// from list
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int Get(int element)
        {
            if (head == null)
            {
                throw new EmptyListException();
            }

            ListElement temp = head;
            while (temp.Next != null && temp.Data != element)
            {
                temp = temp.Next;
            }
            return temp.Data;
        }
    }
}