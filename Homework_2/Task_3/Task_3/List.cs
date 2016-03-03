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
            private int data;
            private ListElement next;

            /// <summary>
            /// Class constructor
            /// </summary>
            /// <param name="value"></param>
            public ListElement(int value)
            {
                this.data = value;
            }

            /// <summary>
            /// Data field properties
            /// </summary>
            public int Data
            {
                get { return data; }
                set { data = value; }
            }

            /// <summary>
            /// Next field properties
            /// </summary>
            public ListElement Next
            {
                get { return next; }
                set { next = value; }
            }
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
                return System.Int32.MinValue;
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