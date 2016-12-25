using System;

namespace TestTest
{
    internal class Player : IOriginator
    {
        private int health;

        public Player()
        {
            health = 100;
        }

        public void GetWound(int wound)
        {
            health -= wound;
        }

        public void GetCure(int cure)
        {
            health += cure;
        }

        public void PrintPulse()
        {
            if (health > 70)
                Console.WriteLine("Green");

            if (health <= 70 && health > 40)
                Console.WriteLine("Yellow");

            if (health <= 40)
                Console.WriteLine("Red");
        }

        public void SetMemento(Memento memento)
        {
            health = memento.GetState();
        }

        public Memento GetMemento()
        {
            return new Memento(health);
        }
    }
}
