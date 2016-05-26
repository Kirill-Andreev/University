using System;

namespace EventLoopNameSpace
{
    /// <summary>
    /// Class that implements methods 
    /// to control cursor position in console
    /// </summary>
    public class MoveCursor
    {
        public void Left(object sender, EventArgs args)
        {
            // When going beyond the boundaries of the buffer 
            // the cursor moves to the other side of the line
            if (Console.CursorLeft - 1 < 0)
            {
                Console.CursorLeft = Console.BufferWidth - 1;
            }
            else
            {
                Console.CursorLeft -= 1;
            }
        }

        public void Right(object sender, EventArgs args)
        {
            if (Console.CursorLeft + 1 >= Console.BufferWidth)
            {
                Console.CursorLeft = 0;
            }
            else
            {
                Console.CursorLeft += 1;
            }
        }

        public void Up (object sender, EventArgs args)
        {
            // When going beyond the boundaries of the buffer 
            // the cursor moves to the other side of the column
            if (Console.CursorTop - 1 < 0)
            {
                Console.CursorTop = Console.BufferHeight - 1;
            }
            else
            {
                Console.CursorTop -= 1;
            }
        }

        public void Down(object sender, EventArgs args)
        {
            if (Console.CursorTop + 1 >= Console.BufferHeight)
            {
                Console.CursorTop = 0;
            }
            else
            {
                Console.CursorTop += 1;
            }
        }
    }
}
