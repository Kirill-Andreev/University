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

            if (position > GetSize())
            {
                throw new IncorrectPositionException();
            }

            if (IsExist(element))
            {
                throw new EqualElementsException("You are trying to add an already existing item!");
            }
            else
            {
                base.Add(position, element);
            }
        }

        /// <summary>
        /// Removes the specified element from list
        /// and throws an exception
        /// when removing a non-existent element
        /// </summary>
        /// <param name="element"></param>
        public override void Remove(int element)
        {
            if (GetSize() == 0)
            {
                throw new EmptyListException();
            }

            if (!IsExist(element))
            {
                throw new NonexistentElementException("You are trying to delete a nonexistent element!");
            }
            else
            {
                base.Remove(GetPos(element));
            }
        }
    }
}
