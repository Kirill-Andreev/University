namespace GraphicEditor
{
    /// <summary>
    /// Command interface
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command
        /// </summary>
        void Execute();

        /// <summary>
        /// Cancellation of the result of the command
        /// </summary>
        void UnExecute();
    }
}
