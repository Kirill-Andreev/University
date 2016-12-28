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

        private Point prevPointLocation;

        public MoveLineCommand(/*LinesList linesListSet,*/ Line lineSet)
        {
            //linesList = linesListSet;
            line = lineSet;
        }

        public void Execute(Point newPoint)
        {
            if (line.pointClicked1)
            {
                prevPointLocation = line.Point1;
                line.Point1 = newPoint;
                line.pointClicked1 = false;
            }
            else
            {
                prevPointLocation = line.Point2;
                line.Point2 = newPoint;
                line.pointClicked2 = false;
            }
        }

        public void UnExecute()
        {

        }
    }
}
