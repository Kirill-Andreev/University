using System;
using System.Drawing;

namespace GraphicEditor
{
    /// <summary>
    /// Class of the line
    /// contains two points which can be clicked
    /// </summary>
    public class Line
    {
        public bool pointClicked1 = false;
        public bool pointClicked2 = false;

        /// <summary>
        /// Maximum vicinity if the point
        /// </summary>
        private const double PointVicinity = 5;
        public TwoPoints coords;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="coords"></param>
        public Line(TwoPoints coords)
        {
            this.coords = coords;
        }

        /// <summary>
        /// Checks is line clicked
        /// </summary>
        /// <returns></returns>
        public bool IsLineClicked()
        {
            return pointClicked1 || pointClicked2;
        }

        /// <summary>
        /// Checks whicj line was clicked
        /// </summary>
        /// <param name="clickedPointCoord"></param>
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
