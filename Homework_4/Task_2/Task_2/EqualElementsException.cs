using System;

namespace ListNameSpace
{
    /// <summary>
    /// Exception class
    /// generating an exception 
    /// when adding already existing element
    /// </summary>
    [Serializable]
    public class EqualElementsException : Exception
    {
        public EqualElementsException() { }
        public EqualElementsException(string message) : base(message) { }
        public EqualElementsException(string message, Exception inner) : base(message, inner) { }
        protected EqualElementsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
