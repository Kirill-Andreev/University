using IStackNameSpace;
using ListNameSpace;

namespace ListStackNameSpace
{
    class ListStack : IStack
    {
        private List stack;

        public ListStack()
        {
            stack = new List();
        }

        public void Push(int value)
        {
            stack.Add(0, value);
        }

        public int Pop()
        {
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
