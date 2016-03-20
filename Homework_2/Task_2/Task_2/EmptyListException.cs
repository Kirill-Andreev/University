﻿using System;

namespace ListNameSpace
{
    /// <summary>
    /// Exception class of empty list
    /// </summary>
    [Serializable]
    public class EmptyListException : ApplicationException
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
