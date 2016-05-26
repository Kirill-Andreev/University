using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericNameSpace
{
    /// <summary>
    /// Implementation of the list with enumerator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class List<T> : IList<T>
    {
        private ListElement Head { get; set; }

        public List()
        {
            Head = new ListElement();
        }

        /// <summary>
        /// Class of list element
        /// whith two properties and two constructors
        /// </summary>
        private class ListElement
        {
            public T Element { get; set; }
            public ListElement Next { get; set; }

            public ListElement(T element)
            {
                this.Element = element;
                this.Next = null;
            }

            public ListElement()
            {
                this.Element = default(T);
                this.Next = null;
            }
        }

        public void Add(T element)
        {
            ListElement newElement = new ListElement(element);

            if (Head.Next == null)
            {
                newElement.Next = Head.Next;
                Head.Next = newElement;
            }
            else
            {
                ListElement temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                newElement.Next = temp.Next;
                temp.Next = newElement;
            }
            
        }

        public void Remove(T element)
        {
            if (Head.Next != null)
            {
                ListElement temp = Head;
                if (temp.Element.Equals(element))
                {
                    Head = temp.Next;
                }
                else
                {
                    while (temp.Next != null && !temp.Next.Element.Equals(element))
                    {
                        temp = temp.Next;
                    }

                    if (temp.Next != null)
                    {
                        temp.Next = temp.Next.Next;
                    }
                    else
                    {
                        temp = null;
                    }
                }
            }
            else
            {
                throw new EmptyListException("List is empty");
            }
        }

        public bool Contains(T element)
        {
            if (Head != null)
            {
                ListElement temp = Head;
                while (temp != null && !temp.Element.Equals(element))
                {
                    temp = temp.Next;
                }
                return temp != null;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method required to implement
        /// the interface IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Implementation of GetEnumerator()
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator(Head);
        }

        /// <summary>
        /// Implementation of list enumerator
        /// </summary>
        private class ListEnumerator : IEnumerator<T>
        {

            ListElement currentPos;
            ListElement Head { get; }

            /// <summary>
            /// Returns current position
            /// </summary>
            public T Current
            {
                get
                {
                    return currentPos.Element;
                }
            }

            /// <summary>
            /// Sets the enumerator on the head of the list
            /// </summary>
            /// <param name="head"></param>
            public ListEnumerator(ListElement head)
            {
                this.Head = head;
                Reset();
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            /// <summary>
            /// Sets current position on the head of the list
            /// </summary>
            public void Reset()
            {
                currentPos = Head;
            }

            /// <summary>
            /// Returns true if we can move 
            /// to the next position of the list
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (currentPos.Next != null)
                {
                    currentPos = currentPos.Next;
                    return true;
                }
                return false;
            }
            
            void IDisposable.Dispose()
            {

            }
        }
    }
}
