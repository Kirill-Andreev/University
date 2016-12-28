using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    public class MoveLineCommand
    {
        Line line;
        LinesList linesList = new LinesList();

        public MoveLineCommand(/*LinesList linesListSet,*/ Line lineSet)
        {
            //linesList = linesListSet;
            line = lineSet;
        }

        public void Execute(Point movedPointCoord, Point newPoint)
        {
            movedPointCoord.X = newPoint.X;
            movedPointCoord.Y = newPoint.Y;
        }
    }
}
