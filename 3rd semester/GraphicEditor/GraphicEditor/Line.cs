using System;
using System.Drawing;

namespace GraphicEditor
{
    public class Line
    {
        public bool pointClicked1 = false;
        public bool pointClicked2 = false;

        private const double PointVicinity = 5;
        public TwoPoints coords;

        public Line(TwoPoints coords)
        {
            this.coords = coords;
        }

        public bool IsLineClicked()
        {
            return pointClicked1 || pointClicked2;
        }

        public void PointOfLineClicked(Point clickedPointCoord)
        {
            if (PointVicinity > Math.Sqrt(Math.Pow((coords.Point1.X - clickedPointCoord.X), 2) + Math.Pow((coords.Point1.Y - clickedPointCoord.Y), 2)))
            {
                pointClicked1 = true;
            }
            else if (PointVicinity > Math.Sqrt(Math.Pow((coords.Point2.X - clickedPointCoord.X), 2) + Math.Pow((coords.Point2.Y - clickedPointCoord.Y), 2)))
            {
                pointClicked2 = true;
            }
        }
    }
}
