using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicEditor
{
    public class Line
    {
        public bool pointClicked1 = false;
        public bool pointClicked2 = false;
        private const double PointVicinity = 5;

        public Point Point1 { get; set; }

        public Point Point2 { get; set; }

        public Line(Point begin, Point end)
        {
            Point1 = begin;
            Point2 = end;
        }

        public void MoveBeginOfLine(Point newPoint)
        {
            Point1 = newPoint;
        }

        public void MoveEndOfLine(Point newPoint)
        {
            Point2 = newPoint;
        }

        public bool IsLineClicked()
        {
            return pointClicked1 || pointClicked2;
        }

        public void PointOfLineClicked(Point clickedPointCoord)
        {
            if (PointVicinity > Math.Sqrt(Math.Pow((Point1.X - clickedPointCoord.X), 2) + Math.Pow((Point1.Y - clickedPointCoord.Y), 2)))
            {
                pointClicked1 = true;
            }
            else if (PointVicinity > Math.Sqrt(Math.Pow((Point2.X - clickedPointCoord.X), 2) + Math.Pow((Point2.Y - clickedPointCoord.Y), 2)))
            {
                pointClicked2 = true;
            }
        }
    }
}
