﻿using System;

namespace QueueNameSpace
{
    /// <summary>
    /// Excweption class of empty queue
    /// </summary>
    [Serializable]
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException() { }
        public EmptyQueueException(string message) : base(message) { }
        public EmptyQueueException(string message, Exception inner) : base(message, inner) { }
        protected EmptyQueueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
