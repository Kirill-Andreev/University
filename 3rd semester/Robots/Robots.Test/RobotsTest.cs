using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotsNameSpace
{
    [TestClass]
    public class RobotsTest
    {
        private List<Vertex> vertexList;
        private bool[,] matrix;

       [TestMethod]
        public void RobotsWillNotCrushTest()
        {
            vertexList = new List<Vertex>
            {
                new Vertex(true),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false),
                new Vertex(true),
                new Vertex(false)
            };

            matrix = new [,]
            {
                { false, true, false, false, false, false, true },
                { true, false, true, false, false, false, true },
                { false, true, false, true, true, false, false },
                { false, false, true, false, true, false, false },
                { false, false, true, true, false, true, true },
                { false, false, false, false, true, false, false },
                { true, true, false, false, true, false, false }
            };

            Graph graph = new Graph(vertexList, matrix);
            Assert.IsTrue(graph.IsDestruct());
        }

        [TestMethod]
        public void RobotsWillCrushTest()
        {
            vertexList = new List<Vertex>
            {
                new Vertex(true),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false),
                new Vertex(true),
                new Vertex(false)
            };

            matrix = new [,]
            {
                { false, true, false, false, false, false, true },
                { true, false, true, false, false, false, false },
                { false, true, false, true, false, false, false },
                { false, false, true, false, true, false, false },
                { false, false, false, true, false, true, true },
                { false, false, false, false, true, false, false },
                { true, false, false, false, true, false, false }
            };

            Graph graph = new Graph(vertexList, matrix);
            Assert.IsFalse(graph.IsDestruct());
        }

        [TestMethod]
        public void OneRobotTest()
        {
            vertexList = new List<Vertex>
            {
                new Vertex(true),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false),
                new Vertex(false)
            };

            matrix = new [,]
            {
                { false, true, false, false, false, false, true },
                { true, false, true, false, false, false, true },
                { false, true, false, true, true, false, false },
                { false, false, true, false, true, false, false },
                { false, false, true, true, false, true, true },
                { false, false, false, false, true, false, false },
                { true, true, false, false, true, false, false }
            };

            Graph graph = new Graph(vertexList, matrix);
            Assert.IsFalse(graph.IsDestruct());
        }
    }
}
