using System;

namespace StackNameSpace
{
    /// <summary>
    /// Exception class of the overflow list
    /// </summary>
    [Serializable]
    public class OverFlowStackException : Exception
    {
        public OverFlowStackException() { }
        public OverFlowStackException(string message) : base(message) { }
        public OverFlowStackException(string message, Exception inner) : base(message, inner) { }
        protected OverFlowStackException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
