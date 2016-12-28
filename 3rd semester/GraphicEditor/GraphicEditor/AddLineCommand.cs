using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    public class AddLineCommand : ICommand
    {
        Line line;
        LinesList linesList = new LinesList();

        public AddLineCommand(LinesList linesListSet, Line lineSet)
        {
            linesList = linesListSet;
            line = lineSet;
        }

        public void Execute()
        {
            linesList.Add(line);
        }
    }
}
