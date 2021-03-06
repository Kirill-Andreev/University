﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class GraphicEditor : Form
    {
        private LinesList linesList = new LinesList();
        private Line line;
        private UndoRedoManager manager = new UndoRedoManager();

        private bool isClicked = false;
        private bool isDrawButtonClicked = true;
        private bool isMoveButtonClicked = false;

        private int xCoord1;
        private int yCoord1;

        private int xCoord2;
        private int yCoord2;

        public GraphicEditor()
        {
            InitializeComponent();
        }

        private void PictureBoxMouseUpHandler(object sender, MouseEventArgs e)
        {
            isClicked = false;
            if (isDrawButtonClicked)
            {
                line = new Line(new TwoPoints { Point1 = new Point(xCoord1, yCoord1), Point2 = new Point(xCoord2, yCoord2) });
                var addLineCommand = new AddLineCommand(linesList, line);
                manager.Execute(addLineCommand);
            }
            else if (isMoveButtonClicked)
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

        private void PictureBoxMouseDownHandler(object sender, MouseEventArgs e)
        {
            isClicked = true;
            if (isDrawButtonClicked)
            {
                xCoord1 = e.X;
                yCoord1 = e.Y;
            }
            else if (isMoveButtonClicked)
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

        private void PictureBoxMouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                xCoord2 = e.X;
                yCoord2 = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void PictureBoxPaintHandler(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            if (isClicked && (isDrawButtonClicked || isMoveButtonClicked))
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
            isDrawButtonClicked = false;
            isMoveButtonClicked = true;
        }

        private void DrawButtonClick(object sender, EventArgs e)
        {
            isMoveButtonClicked = false;
            isDrawButtonClicked = true;
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
