namespace ListNameSpace
{
    /// <summary>
    /// List class with overridden 
    /// functions of adding and removing
    /// </summary>
    public class UniqueList : List
    {
        /// <summary>
        /// Adds a new element 
        /// at the specified position in the list
        /// and throws an exception 
        /// when adding already existing element
        /// </summary>
        /// <param name="position"></param>
        /// <param name="element"></param>
        public override void Add(int position, int element)
        {
            ListElement newListElement = new ListElement(element);

            if (position > size)
            {
                throw new IncorrectPositionException();
            }

            ListElement check = head;
            bool areEqual = false;
            if (size == 1)
            {
                if (check.Data == element)
                {
                    areEqual = true;
                }
            }
            else if (size != 0)
            {
                while (check.Next != null)
                {
                    if (check.Data == element)
                    {
                        areEqual = true;
                    }
                    check = check.Next;
                }
            }
            
            if (areEqual)
            {
                throw new EqualElementsException("You are trying to add an already existing item!");
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

        /// <summary>
        /// Removes the specified element from list
        /// and throws an exception
        /// when removing a non-existent element
        /// </summary>
        /// <param name="element"></param>
        public override void Remove(int element)
        {
            if (size == 0)
            {
                throw new EmptyListException();
            }

            ListElement check = head;
            bool areEqual = true;
            while (check != null)
            {
                if (check.Data == element)
                {
                    areEqual = false;
                }
                check = check.Next;
            }

            if (areEqual)
            {
                throw new NonexistentElementException("You are trying to delete a nonexistent element!");
            }

            ListElement temp = head;

            if (temp.Data == element)
            {
                head = head.Next;
                size--;
            }
            else
            {
                ListElement temp1 = head;
                ListElement temp2 = head;
                int counter = size - 1;
                temp1 = temp1.Next;
                while (temp1.Next != null && counter != 1)
                {
                    temp1 = temp1.Next;
                    temp2 = temp2.Next;
                    counter--;
                }
                temp2.Next = temp1.Next;
                size--;
            }
        }
    }
}
