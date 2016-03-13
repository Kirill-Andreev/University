namespace ListNameSpace
{
    /// <summary>
    /// List class implements the methods 
    /// declared in the interface
    /// </summary>
    public class List : IList
    {
        private int size;
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

        private void ErrorMessage()
        {
            System.Console.WriteLine("Error! Enter the correct position!");
        }

        public void Add(int position, int newElement)
        {
            ListElement newListElement = new ListElement(newElement);

            if (position > size)
            {
                ErrorMessage();
                return;
            }

            if (position == 0)
            {
                newListElement.Next = head;
                head = newListElement;
            }
            else
            {
                ListElement temp = head;
                while (temp.Next != null && position != 1)
                {
                    temp = temp.Next;
                    position--;
                }
                newListElement.Next = temp.Next;
                temp.Next = newListElement;
            }
            size++;
        }

        public void Remove(int position)
        {
            if (position >= size)
            {
                ErrorMessage();
                return;
            }
            if (position == 0)
            {
                head = head.Next;
                size--;
            }
            else
            {
                ListElement temp1 = head;
                ListElement temp2 = head;

                temp1 = temp1.Next;
                while (temp1.Next != null && position != 1)
                {
                    temp1 = temp1.Next;
                    temp2 = temp2.Next;
                    position--;
                }
                temp2.Next = temp1.Next;
                size--;
            }
        }

        public int Get(int position)
        {
            if (position >= size)
            {
                ErrorMessage();
                return System.Int32.MinValue;
            }

            ListElement temp = head;

            while (temp.Next != null && position != 0)
            {
                temp = temp.Next;
                position--;
            }
            return temp.Data;
        }

        public int GetSize()
        {
            return size;
        }
    }
}
