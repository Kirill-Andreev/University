namespace GenericNameSpace
{
    /// <summary>
    /// Implementation of a generic stack class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IStack<T>
    {
        private StackElement Head { set; get; }

        private class StackElement
        {
            public T Element { get; set; }
            public StackElement Next { get; set; }

            public StackElement(T element, StackElement next)
            {
                this.Element = element;
                this.Next = next;
            }
        }

        public void Push(T element)
        {
            if (Head == null)
            {
                Head = new StackElement(element, null);
            }
            else
            {
                StackElement temp = new StackElement(element, Head);
                Head = temp;
            }
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new EmptyStackException("Stack is empty!");
            }
            T element = Head.Element;
            Head = Head.Next;
            return element;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
    }

}
