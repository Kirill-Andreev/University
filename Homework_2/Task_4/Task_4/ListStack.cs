namespace StackNameSpace
{
    class ListStack : IStack
    {
        private ListNameSpace.List stack;

        public ListStack()
        {
            stack = new ListNameSpace.List();
        }

        public void Push(int value)
        {
            if (IsOverflowed())
            {
                throw new OverFlowStackException();
            }
            stack.Add(0, value);
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new EmptyStackException();
            }
            int temp = stack.Get(0);
            stack.Remove(0);
            return temp;
        }

        public bool IsEmpty()
        {
            return stack.GetSize() == 0;
        }

        public bool IsOverflowed()
        {
            return stack.GetSize() == 100;
        }
    }
}
