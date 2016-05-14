namespace EventLoopNameSpace
{
    /// <summary>
    /// Main class of the program
    /// that triggers an event and starts the event loop
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var moveCursor = new MoveCursor();
            eventLoop.LeftHandler += moveCursor.Left;
            eventLoop.RightHandler += moveCursor.Right;
            eventLoop.UpHandler += moveCursor.Up;
            eventLoop.DownHandler += moveCursor.Down;
            eventLoop.Run();
        }
    }
}
