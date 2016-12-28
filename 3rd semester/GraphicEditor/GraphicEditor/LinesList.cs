using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
