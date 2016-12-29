using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    public class MoveLineCommand : ICommand
    {
        Line line;
        LinesList linesList = new LinesList();

        private TwoPoints prevCoords;
        public TwoPoints coords;

        public MoveLineCommand(Line lineSet, TwoPoints coords)
        {
            line = lineSet;
            this.coords = coords;
        }

        public void Execute()
        {
            if (line.pointClicked1)
            {
                line.pointClicked1 = false;
            }
            else
            {
                line.pointClicked2 = false;
            }

            prevCoords = line.coords;
            line.coords = coords;
        }

        public void UnExecute()
        {
            line.coords = prevCoords;
        }
    }
}
