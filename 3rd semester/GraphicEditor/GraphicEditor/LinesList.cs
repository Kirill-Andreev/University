using System.Collections.Generic;

namespace GraphicEditor
{
    public class LinesList
    {
        public List<Line> lineList = new List<Line>();

        public void Add(Line line)
        {
            lineList.Add(line);
        }
    }
}
