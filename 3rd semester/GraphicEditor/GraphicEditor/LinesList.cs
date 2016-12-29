using System.Collections.Generic;

namespace GraphicEditor
{
    /// <summary>
    /// List of lines class
    /// </summary>
    public class LinesList
    {
        public List<Line> lineList = new List<Line>();

        /// <summary>
        /// Add line in list
        /// </summary>
        /// <param name="line"></param>
        public void Add(Line line)
        {
            lineList.Add(line);
        }
    }
}
