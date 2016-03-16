using System;

namespace ExceptionNamespace
{
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
