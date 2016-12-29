using System.Collections.Generic;

namespace GraphicEditor
{
    public class UndoRedoManager
    {
        Stack<ICommand> UndoStack { get; set; }
        Stack<ICommand> RedoStack { get; set; }

        public UndoRedoManager()
        {
            UndoStack = new Stack<ICommand>();
            RedoStack = new Stack<ICommand>();
        }

        public void Undo()
        {
            if (UndoStack.Count > 0)
            {
                //изымаем команду из стека
                var command = UndoStack.Pop();

                //отменяем действие команды
                command.UnExecute();

                //заносим команду в стек Redo
                RedoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (RedoStack.Count > 0)
            {
                //изымаем команду из стека
                var command = RedoStack.Pop();

                //выполняем действие команды
                command.Execute();

                //заносим команду в стек Undo
                UndoStack.Push(command);
            }
        }

        //выполняем команду
        public void Execute(ICommand command)
        {
            //выполняем команду
            command.Execute();

            //заносим в стек Undo
            UndoStack.Push(command);

            //очищаем стек Redo
            RedoStack.Clear();
        }

        public void Undo(int count)
        {
            for (int i = 0; i < count; i++)
                Undo();
        }

        public void Redo(int count)
        {
            for (int i = 0; i < count; i++)
                Redo();
        }
    }
}
