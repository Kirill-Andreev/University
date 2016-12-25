using System;

namespace GenericNameSpace
{
    /// <summary>
    /// Exception class of empty stack
    /// </summary>
    [Serializable]
    public class EmptyStackException : Exception
    {
        public EmptyStackException() { }
        public EmptyStackException(string message) : base(message) { }
        public EmptyStackException(string message, Exception inner) : base(message, inner) { }
        protected EmptyStackException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
