namespace TestTest
{
    internal class Memento
    {
        private int health;

        public Memento(int _health)
        {
            health = _health;
        }

        public int GetState()
        {
            return health;
        }
    }
}
