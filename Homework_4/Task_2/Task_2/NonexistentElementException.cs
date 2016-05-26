using System;

namespace ListNameSpace
{
    /// <summary>
    /// Exception class
    /// generating an exception 
    /// when removing a non-existent element
    /// </summary>
    [Serializable]
    public class NonexistentElementException : Exception
    {
        public NonexistentElementException() { }
        public NonexistentElementException(string message) : base(message) { }
        public NonexistentElementException(string message, Exception inner) : base(message, inner) { }
        protected NonexistentElementException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
