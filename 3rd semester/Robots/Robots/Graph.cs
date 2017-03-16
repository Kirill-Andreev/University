using System.Collections.Generic;

namespace RobotsNameSpace
{
    public enum Colour { Black, White }

    /// <summary>
    /// Class of graph vertex with white colour default
    /// </summary>
    public class Vertex
    {
        public Colour VertexColour { get; set; }

        /// <summary>
        /// Shows is robot in vertex
        /// </summary>
        public bool HaveRobot { get; set; }

        /// <summary>
        /// Vertex constructor
        /// </summary>
        /// <param name="haveRobot"></param>
        public Vertex(bool haveRobot)
        {
            HaveRobot = haveRobot;
            VertexColour = Colour.White;
        }
    }

    /// <summary>
    /// Class of graph that models the behavior of robots
    /// </summary>
    public class Graph
    {
        private List<Vertex> vertexList;
        private List<int> colouredVertexList  = new List<int>();
        private List<int> visitedVertexList = new List<int>();
        private bool[,] adjacencyMatrix;

        /// <summary>
        /// Graph constructor
        /// </summary>
        /// <param name="list"></param>
        /// <param name="matrix"></param>
        public Graph(List<Vertex> list, bool[,] matrix)
        {
            vertexList = list;
            adjacencyMatrix = matrix;
        }

        /// <summary>
        /// Paint the graph depending on ties
        /// </summary>
        private void GraphColoring()
        {
            vertexList[0].VertexColour = Colour.Black;
            visitedVertexList.Add(0);
            colouredVertexList.Add(0);
            while (colouredVertexList.Count != 0)
            {
                ColouringNeighOfNeigh(colouredVertexList[0]);
            }
        }

        /// <summary>
        /// Colouring neighbors of neighbor of vertex
        /// </summary>
        /// <param name="vertex"></param>
        private void ColouringNeighOfNeigh(int vertex)
        {
            for (int i = 0; i < adjacencyMatrix.GetLength(0); ++i)
            {
                if (adjacencyMatrix[vertex, i] && !visitedVertexList.Contains(i))
                {
                    for (int j = 0; j < adjacencyMatrix.GetLength(0); ++j)
                    {
                        if (adjacencyMatrix[i, j] && !colouredVertexList.Contains(j))
                        {
                            vertexList[j].VertexColour = Colour.Black;
                            colouredVertexList.Add(j);
                        }
                    }

                    visitedVertexList.Add(i);
                }
            }

            colouredVertexList.Remove(vertex);
        }

        /// <summary>
        /// Checks whether all robots on same colour vertexes
        /// </summary>
        /// <returns></returns>
        private bool IsOnSameColour()
        {
            int blackCount = 0;
            int whiteCount = 0;
            for (int i = 0; i < vertexList.Count; ++i)
            {
                if (vertexList[i].HaveRobot)
                {
                    if (vertexList[i].VertexColour == Colour.Black)
                    {
                        blackCount++;
                    }
                    else
                    {
                        whiteCount++;
                    }
                }
            }

            return (blackCount == 0 || whiteCount == 0) && !(blackCount == 1 && whiteCount == 0) && !(blackCount == 0 && whiteCount == 1);
        }

        /// <summary>
        /// Checks whether all robots destroy
        /// </summary>
        /// <returns></returns>
        public bool IsDestruct()
        {
            GraphColoring();
            return IsOnSameColour();
        }
        
    }
}
