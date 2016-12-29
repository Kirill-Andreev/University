using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    /// <summary>
    /// Command which adds and removes the line in lines list
    /// </summary>
    public class AddLineCommand : ICommand
    {
        Line line;
        LinesList linesList = new LinesList();

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="linesListSet"></param>
        /// <param name="lineSet"></param>
        public AddLineCommand(LinesList linesListSet, Line lineSet)
        {
            linesList = linesListSet;
            line = lineSet;
        }

        /// <summary>
        /// Adds line in lines list
        /// </summary>
        public void Execute()
        {
            linesList.Add(line);
        }

        /// <summary>
        /// Removes line from lines list
        /// </summary>
        public void UnExecute()
        {
            linesList.lineList.RemoveAt(linesList.lineList.Count - 1);
        }
    }
}
