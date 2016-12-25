using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MapNameSpace;

namespace Task_1.Test
{
    [TestClass]
    public class MapTest
    {
        [TestMethod]
        public void MapFunctionTest()
        {
            Map map = new Map();
            List<int> list = map.MapFunction(new List<int>() { 1, 2, 3 }, function => function * 2);
            for (int i = 0; i < list.Count; ++i)
            {
                Assert.AreEqual(list[i], (i + 1) * 2);
            }
        }
    }
}
