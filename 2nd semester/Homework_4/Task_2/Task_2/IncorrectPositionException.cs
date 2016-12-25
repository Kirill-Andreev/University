using System;

namespace ListNameSpace
{
    /// <summary>
    /// Exception class of incorrect position 
    /// at which refer to non-existent memory space
    /// </summary>
    [Serializable]
    public class IncorrectPositionException : ApplicationException
    {
        public IncorrectPositionException() { }
        public IncorrectPositionException(string message) : base(message) { }
        public IncorrectPositionException(string message, Exception inner) : base(message, inner) { }
        protected IncorrectPositionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
