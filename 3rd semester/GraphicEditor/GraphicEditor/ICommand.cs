namespace GraphicEditor
{
    public interface ICommand
    {
        void Execute();

        void UnExecute();
    }
}
