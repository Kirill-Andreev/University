using System;

namespace StackNameSpace
{
    /// <summary>
    /// Exception class of the empty list
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
