namespace GraphicEditor
{
    /// <summary>
    /// Command that can move line
    /// and cancel this move
    /// </summary>
    public class MoveLineCommand : ICommand
    {
        Line line;
        LinesList linesList = new LinesList();

        private TwoPoints prevCoords;
        public TwoPoints coords;

        /// <summary>
        /// Class constructor
        /// which takes as argument moving line
        /// and new coordinates of its point
        /// </summary>
        /// <param name="lineSet"></param>
        /// <param name="coords"></param>
        public MoveLineCommand(Line lineSet, TwoPoints coords)
        {
            line = lineSet;
            this.coords = coords;
        }

        /// <summary>
        /// Rememberes previuos coordinates
        /// and moves line
        /// </summary>
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

        /// <summary>
        /// Returns line on previous coordinates
        /// </summary>
        public void UnExecute()
        {
            line.coords = prevCoords;
        }
    }
}
