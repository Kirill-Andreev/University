using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class GraphicEditor : Form
    {
        ICommand addLineCommand;
        MoveLineCommand moveLineCommand;
        LinesList linesList = new LinesList();
        Line line;

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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
            if(IsDrawButtonClicked)
            {
                line = new Line(new Point(xCoord1, yCoord1), new Point(xCoord2, yCoord2));
                addLineCommand = new AddLineCommand(linesList, line);
                addLineCommand.Execute();
            }
            else if (IsMoveButtonClicked)
            {
                foreach (var line in linesList.lineList)
                {
                    if (line.IsLineClicked())
                    {
                        moveLineCommand = new MoveLineCommand(line);
                        moveLineCommand.Execute(e.Location);
                    }
                }
            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
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
                        xCoord1 = line.Point2.X;
                        yCoord1 = line.Point2.Y;
                        xCoord2 = e.X;
                        yCoord2 = e.Y;
                    }
                    else if (line.pointClicked2)
                    {
                        xCoord1 = line.Point1.X;
                        yCoord1 = line.Point1.Y;
                        xCoord2 = e.X;
                        yCoord2 = e.Y;
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                xCoord2 = e.X;
                yCoord2 = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            if (IsDrawButtonClicked || IsMoveButtonClicked && line.IsLineClicked())
            {
                e.Graphics.DrawLine(pen, new Point(xCoord1, yCoord1), new Point(xCoord2, yCoord2));
            }
            
            foreach (var line in linesList.lineList)
            {
                e.Graphics.DrawLine(pen, line.Point1, line.Point2);
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
    }
}
