namespace HashTableNameSpace
{
    /// <summary>
    /// Exception class of the empty list
    /// </summary>
    [System.Serializable]
    public class EmptyListException : System.Exception
    {
        public EmptyListException() { }
        public EmptyListException(string message) : base(message) { }
        public EmptyListException(string message, System.Exception inner) : base(message, inner) { }
        protected EmptyListException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}