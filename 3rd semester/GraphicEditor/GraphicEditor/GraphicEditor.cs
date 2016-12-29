using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class GraphicEditor : Form
    {
        LinesList linesList = new LinesList();
        Line line;
        private UndoRedoManager manager = new UndoRedoManager();

        bool IsClicked = false;
        bool IsDrawButtonClicked = true;
        bool IsMoveButtonClicked = false;

        public int xCoord1;
        public int yCoord1;

        public int xCoord2;
        public int yCoord2;

        public GraphicEditor()
        {
            InitializeComponent();
        }

        private void pictureBoxMouseUpHandler(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            if (IsDrawButtonClicked)
            {
                line = new Line(new TwoPoints { Point1 = new Point(xCoord1, yCoord1), Point2 = new Point(xCoord2, yCoord2) });
                var addLineCommand = new AddLineCommand(linesList, line);
                manager.Execute(addLineCommand);
            }
            else if (IsMoveButtonClicked)
            {
                foreach (var line in linesList.lineList)
                {
                    if (line.IsLineClicked())
                    {
                        var moveLineCommand = new MoveLineCommand(line, new TwoPoints { Point1 = new Point(xCoord1, yCoord1), Point2 = e.Location });
                        manager.Execute(moveLineCommand);
                    }
                }
            }

            pictureBox1.Invalidate();
        }

        private void pictureBoxMouseDownHandler(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            if (IsDrawButtonClicked)
            {
                xCoord1 = e.X;
                yCoord1 = e.Y;
            }
            else if (IsMoveButtonClicked)
            {
                foreach (var line in linesList.lineList)
                {
                    line.PointOfLineClicked(new Point(e.X, e.Y));
                    if (line.pointClicked1)
                    {
                        xCoord1 = line.coords.Point2.X;
                        yCoord1 = line.coords.Point2.Y;
                        xCoord2 = e.X;
                        yCoord2 = e.Y;
                    }
                    else if (line.pointClicked2)
                    {
                        xCoord1 = line.coords.Point1.X;
                        yCoord1 = line.coords.Point1.Y;
                        xCoord2 = e.X;
                        yCoord2 = e.Y;
                    }
                }
            }
        }

        private void pictureBoxMouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                xCoord2 = e.X;
                yCoord2 = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBoxPaintHandler(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            if (IsClicked && (IsDrawButtonClicked || IsMoveButtonClicked && line.IsLineClicked()))
            {
                e.Graphics.DrawLine(pen, new Point(xCoord1, yCoord1), new Point(xCoord2, yCoord2));
            }
            
            foreach (var line in linesList.lineList)
            {
                e.Graphics.DrawLine(pen, line.coords.Point1, line.coords.Point2);
            }
        }

        private void MoveButtonClick(object sender, EventArgs e)
        {
            IsDrawButtonClicked = false;
            IsMoveButtonClicked = true;
        }

        private void DrawButtonClick(object sender, EventArgs e)
        {
            IsMoveButtonClicked = false;
            IsDrawButtonClicked = true;
        }

        private void UndoButtonClick(object sender, EventArgs e)
        {
            manager.Undo();
            pictureBox1.Invalidate();
        }

        private void RedoButtonClick(object sender, EventArgs e)
        {
            manager.Redo();
            pictureBox1.Invalidate();
        }
    }
}
