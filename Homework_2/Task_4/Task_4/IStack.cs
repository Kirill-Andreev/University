namespace IStackNameSpace
{
    interface IStack
    {
        void Push(int value);

        int Pop();

        bool IsEmpty();

        bool IsOverflowed();
    }
}
