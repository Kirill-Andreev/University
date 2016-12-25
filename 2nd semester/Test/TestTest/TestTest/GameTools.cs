using System;

namespace TestTest
{
    internal class GameTools
    {
        private Memento _memento;

        public void SaveState(IOriginator originator)
        {
            if (originator == null)
                throw new ArgumentNullException("originator is null");

            _memento = originator.GetMemento();

            Console.WriteLine("Save state");
        }

        public void LoadState(IOriginator originator)
        {
            if (originator == null)
                throw new ArgumentNullException("originator is null");
            if (_memento == null)
                throw new ArgumentNullException("memento is null");

            originator.SetMemento(_memento);

            Console.WriteLine("Load State");
        }
    }
}
