using System;

namespace GenericNameSpace
{
    /// <summary>
    /// Exception class of empty list
    /// </summary>
    [Serializable]
    public class EmptyListException : Exception
    {
        public EmptyListException() { }
        public EmptyListException(string message) : base(message) { }
        public EmptyListException(string message, Exception inner) : base(message, inner) { }
        protected EmptyListException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
